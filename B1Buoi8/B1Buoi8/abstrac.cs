using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1Buoi8
{
    public partial class abstrac : Component
    {
        public abstrac()
        {
            InitializeComponent();
        }

        public abstrac(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
