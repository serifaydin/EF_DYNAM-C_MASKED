using System;
using System.Windows.Forms;
using WFA_MaskedApp.DataModels;
using WFA_MaskedApp.UnitOfWork;

namespace WFA_MaskedApp
{
    public partial class Form1 : Form
    {
        private readonly PersonUnitOfWork _personUoW;
        private readonly MaskedPersonUnitOfWork _maskedPersonUoW;

        public Form1()
        {
            InitializeComponent();
            _personUoW = new PersonUnitOfWork();
            _maskedPersonUoW = new MaskedPersonUnitOfWork();
        }

        protected override void OnLoad(EventArgs e)
        {
            MaskedDataLoad();
            UnMaskedDataLoad();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Person _per = new Person()
            {
                Adress = txtSurname.Text,
                EMail = txtEmail.Text,
                Name = txtName.Text,
                Phone = txtPhone.Text,
                PrivateKey = txtPrivateKey.Text,
                SurName = txtSurname.Text
            };
            _personUoW.Add(_per);

            MaskedDataLoad();
            UnMaskedDataLoad();
        }

        public void MaskedDataLoad()
        {
            dgMasked.DataSource = _maskedPersonUoW.GetMaskedPersons();
        }

        public void UnMaskedDataLoad()
        {
            dgUnMasked.DataSource = _personUoW.GetPersons();
        }
    }
}