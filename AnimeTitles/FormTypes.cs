using AnimeTitles.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimeTitles
{
    public partial class FormTypes : Form
    {
        private AnimeTitlesContext db;
        public FormTypes()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AnimeTitlesContext();
            this.db.AnimeTypes.Load();
            this.dataGridViewType.DataSource = this.db.AnimeTypes.Local.OrderBy(o=>o.TypeOfAnime).ToList();
            dataGridViewType.Columns["Id"].Visible = false;
            dataGridViewType.Columns["AnimeTitles"].Visible = false;

            dataGridViewType.Columns["TypeOfAnime"].HeaderText = "Тип";
        }
        private void FormType_Load(object sender, EventArgs e)
        {

        }
    }
}
