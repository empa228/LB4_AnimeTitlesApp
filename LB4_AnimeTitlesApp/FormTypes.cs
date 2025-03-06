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

        private void buttonTypeUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypes.SelectedRows.Count == 0)
                return;

            int index = dataGridViewTypes.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewTypes[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            AnimeType animeType = db.AnimeTypes.Find(id);

            FormTypeAdd formTypeAdd = new();

            formTypeAdd.TextBoxTypeName.Text = animeType.AnimeOfType;

            DialogResult result = formTypeAdd.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            animeType.AnimeOfType = formTypeAdd.TextBoxTypeName.Text;

            MessageBox.Show("Объект обновлен");

            db.SaveChanges();
            this.dataGridViewTypes.DataSource = this.db.AnimeTypes.Local
                .OrderBy(o => o.AnimeOfType).ToList();
        }

        private void buttonTypeDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypes.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            int index = dataGridViewTypes.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewTypes[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            AnimeType animeType = db.AnimeTypes.Find(id);

            db.AnimeTypes.Remove(animeType);

            db.SaveChanges();
            MessageBox.Show("Объект удален");
            this.dataGridViewTypes.DataSource = this.db.AnimeTypes.Local
                .OrderBy(o => o.AnimeOfType).ToList();
        }
    }
}
