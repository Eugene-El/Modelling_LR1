using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerationApplication
{
    public partial class NumberPageList : UserControl
    {
        public NumberPageList()
        {
            InitializeComponent();
        }

        private List<double> _numberList;
        public List<double> NumberList
        {
            get
            {
                return _numberList;
            }
            set
            {
                _numberList = value;

                Page = 0;
                numbersList.DataSource = _numberList?.Skip(Page * PageSize).Take(PageSize).ToList();

            }
        }

        public int PageSize { get; set; } = 10;
        public int PageCount { get { return _numberList == null? 0 : ( _numberList.Count / PageSize + ((_numberList.Count % PageSize == 0)? 0 : 1) ); } }

        private int _page;
        public int Page
        {
            get
            {
                return _page;
            }
            private set
            {
                _page = value;
                pageTxt.Text = _page + " / " + PageCount;
            }
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            if (_numberList != null)
            {
                Page = (Page + 1) % PageCount;
                numbersList.DataSource = _numberList.Skip(Page * PageSize).Take(PageSize).ToList();
            }
        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            if (_numberList != null)
            {
                Page = ((Page - 1) < 0 ? PageCount : Page - 1);
                numbersList.DataSource = _numberList.Skip(Page * PageSize).Take(PageSize).ToList();
            }
        }
    }
}
