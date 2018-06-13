using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormExtensions;
using DAL;
using Entities;
using BLL;

namespace WinUI.WinForms
{
    public partial class fmSickList : Form
    {
        private PersCardRepository _repoPersCard = new PersCardRepository(SetupProgram.Connection);
        private SickListRepository _repoSickList = new SickListRepository(SetupProgram.Connection);
        private RefDepRepository _repoDep = new RefDepRepository(SetupProgram.Connection);

        private List<RefDep> _refDeps = new List<RefDep>(); //кэш
        private List<SickList> _sickLists = new List<SickList>(); //кэш
        private List<PersCard> _persCards = new List<PersCard>(); //кэш
        //Параметры запроса
        private int _depId = 0;
        private DateTime _datBeg = DateTime.MinValue;
        private DateTime _datEnd = DateTime.MinValue;

        public fmSickList(Form owner)
        {
            InitializeComponent();
            this.SingleFormMode(owner);
        }
    }
}
