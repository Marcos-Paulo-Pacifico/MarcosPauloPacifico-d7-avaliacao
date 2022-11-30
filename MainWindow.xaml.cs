using MarcosPauloPacifico_d7_avaliacao.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;


namespace MarcosPauloPacifico_d7_avaliacao
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Context context;



        public MainWindow(Context context)
        {
            this.context = context;
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var oi = context.Users.ToList();


            foreach(var user in oi)
            {
                if (user.Email == Email.Text)
                {
                    if (user.Password == Password.Text)
                    {
                        MessageBox.Show("Usuário logado com êxito!");
                    }
                    else MessageBox.Show("Senha Inválida");
                }
                else MessageBox.Show("Usuário não encontrado");
            }
            
        }
    }
}
