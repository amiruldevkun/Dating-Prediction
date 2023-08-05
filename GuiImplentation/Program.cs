using GuiImplentation;
using System.Runtime.CompilerServices;

namespace GuiImplentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1("Dating Predictions by AmirulDevKun"));
            
        }
    }

    public class Imports { 
        
        
    }
}

namespace Dating_Prediction {


    public static class Start { 
    
        public static void InvokeOtherParams()
        {
            Program.Main();
        }
    }
}