using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinesWeeper.WindowsForms.Views;
using MinesWeeper.Common.Models;



namespace MinesWeeper.WindowsForms
{
    static class Program
    {
        //Views
        public static ViewMinesWeeper V_MinesWeeper { get; private set; }
        public static ViewMenu V_Menu{ get; private set; }
        //Models
        public static Jogador M_Jogador { get; private set; }
        public static Peca M_Peca { get; private set; }
        public static Jogo M_Jogo { get; private set; }
        //Controllers

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Models
            M_Jogador = new Jogador();
            M_Peca = new Peca();
            M_Jogo = new Jogo();
            //Views
            V_MinesWeeper = new ViewMinesWeeper();
            V_Menu = new ViewMenu();
            //Controllers

            Application.Run(V_Menu);
        }
    }
}
