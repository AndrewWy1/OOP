using HotelSystem_EF.Bll.DTO.User;
using HotelSystem_EF.Dal.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UIWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HttpClient client = new HttpClient();

        public ObservableCollection<UserDTO> Users { get; set; } = new ObservableCollection<UserDTO>();

        public MainWindow()
        {
            client.BaseAddress = new Uri("https://localhost:7284/api/user/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            InitializeComponent();

            DataContext = this;
        }



        private async void Button_Click_Load_all_Instruments(object sender, RoutedEventArgs e) => await this.GetlAllUsersAsync();
        private async void Button_Click_Add_New_Instrument(object sender, RoutedEventArgs e) => await this.CreateAsync();



        private async Task GetlAllUsersAsync()
        {
            var response = await client.GetStringAsync("Return_all_users");
            var users = JsonConvert.DeserializeObject<IEnumerable<UserDTO>>(response);

            Users.Clear();
            foreach (var user in users)
            {
                Users.Add(user);
            }
        }
        private async Task CreateAsync()
        {

            PostUserDTO user = new PostUserDTO
            {
                FirstName = txtFirst.Text,
                LastName = txtSecond.Text,
                Email = txtEmail.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            await client.PostAsJsonAsync("Insert_user", user);
        }
        private async void Button_Click_Remove(object sender, RoutedEventArgs e)
        {
            if (UserData.SelectedItem is UserDTO selectedUser)
            {
                await DeleteAsync(selectedUser.Id);
            }
        }

        private async Task DeleteAsync(int userId)
        {
            await client.DeleteAsync($"Remove_user/{userId}");
        }
    }
}
