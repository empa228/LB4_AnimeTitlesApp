using LB4_AnimeTitlesApp.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using AppContext = LB4_AnimeTitlesApp.Models.AppContext;

namespace LB4_AnimeTitlesApp
{
    public partial class FormTypes : Form
    {
        private AppContext db;
        public FormTypes()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.AnimeTypes.Load();
            this.dataGridViewTypes.DataSource = this.db.AnimeTypes.Local
                .OrderBy(o => o.AnimeOfType).ToList();

            // сокрытие некоторых столбцов
            dataGridViewTypes.Columns["Id"].Visible = false;
            dataGridViewTypes.Columns["AnimeTitles"].Visible = false;

            // изменение названий заголовков столбцов
            dataGridViewTypes.Columns["AnimeOfType"].HeaderText = "Тип";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void buttonTypeAdd_Click(object sender, EventArgs e)
        {
            FormTypeAdd formTypeAdd = new();
            DialogResult result = formTypeAdd.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            if (formTypeAdd.TextBoxTypeName.Text == String.Empty)
                MessageBox.Show("Поле не может быть пустым");

            AnimeType animeType = new AnimeType
            {
                AnimeOfType = formTypeAdd.TextBoxTypeName.Text
            };

            db.AnimeTypes.Add(animeType);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewTypes.DataSource = this.db.AnimeTypes.Local
                .OrderBy(o => o.AnimeOfType).ToList();
        }
    }
}
