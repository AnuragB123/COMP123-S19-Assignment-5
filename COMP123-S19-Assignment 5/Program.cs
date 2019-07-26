using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S19_Assignment_5
{
    static class Program
    {
        public static Dictionary<FormName, Form> forms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            forms = new Dictionary<FormName, Form>();
            forms.Add(FormName.SPLASH_SCREEN, new SplashScreenForm());
            forms.Add(FormName.START_FORM, new StartForm());
            forms.Add(FormName.SELECT_FORM, new SelectForm());
            forms.Add(FormName.PRODUCT_INFO_FORM, new ProductInfoForm());

            Application.Run(forms[FormName.SPLASH_SCREEN]);
        }
    }
}
