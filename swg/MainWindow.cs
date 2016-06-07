using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swg
{
    public partial class MainWindow : Form
    {

        private List<Tuple<string, string>> cities;
        private List<string> all_cities;

        public MainWindow()
        {
            InitializeComponent();
            PopulateData();
            FilterSetup();
        }

        private void PopulateData()
        {
            cities = new List<Tuple<string, string>>();

            foreach (string trainer in File.ReadLines(@"C:\Users\cbaze\Downloads\swgapp\trainers.data"))
            {
                string[] trainer_info = trainer.Split(new[] { "|" }, StringSplitOptions.None);

                string profession = trainer_info[0];
                string planet = trainer_info[1];
                string city = trainer_info[2];
                string waypoint = trainer_info[3];

                cities.Add(new Tuple<string, string>(city, planet));

                dgTrainers.Rows.Add(profession, planet, city, waypoint);
            }

            foreach (string informant in File.ReadLines(@"C:\Users\cbaze\Downloads\swgapp\informants.data"))
            {
                string[] informant_info = informant.Split(new[] { "|" }, StringSplitOptions.None);

                string city = informant_info[0];
                string planet = informant_info[1];
                string waypoint = informant_info[2];
                string rank = informant_info[3];

                dgInformants.Rows.Add(rank, planet, city, waypoint);
            }
        }

        private void FilterSetup()
        {
            all_cities = new List<string>();
            all_cities = cbTrainersCity.Items.Cast<string>().ToList();

            cbTrainersPlanet.SelectedValueChanged += CbTrainersPlanet_SelectedValueChanged;

            cbTrainerProfession.SelectedIndex = 0;
            cbTrainersPlanet.SelectedIndex = 0;
            cbTrainersCity.SelectedIndex = 0;
        }

        private void CbTrainersPlanet_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTrainersPlanet.SelectedIndex != 0)
            {

                string currentPlanet = cbTrainersPlanet.Text;
                List<string> currentPlanetCities = new List<string>();
                cbTrainersCity.Items.Clear();

                foreach (Tuple<string, string> city in cities)
                {
                    if (city.Item2.Equals(currentPlanet))
                    {
                        if (!currentPlanetCities.Contains(city.Item1))
                            currentPlanetCities.Add(city.Item1);
                    }
                }

                foreach (string city in currentPlanetCities)
                {
                    cbTrainersCity.Items.Add(city);
                }

            }
            else
            {
                cbTrainersCity.Items.Clear();

                foreach (string city in all_cities)
                {
                    cbTrainersCity.Items.Add(city);
                }
            }

        }

        private void FilterData()
        {
            
        }
    }
}
