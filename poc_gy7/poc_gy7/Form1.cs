using poc_gy7.Entities;
using poc_gy7.ServiceReference1;
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
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace poc_gy7
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();
        public Form1()
        {
            InitializeComponent();
            string xmlstring = Consume();
            LoadXml(xmlstring);
            dataGridView1.DataSource = Rates;
            Charting();
        }  
        string  Consume()
        {
            MNBArfolyamServiceSoapClient mnbService = new MNBArfolyamServiceSoapClient();
            GetExchangeRatesRequestBody request = new GetExchangeRatesRequestBody();
            request.currencyNames = "EUR";
            request.endDate = "2020-01-01";
            request.currencyNames = "2020-06-30";
            mnbService.GetExchangeRates(request);
            var response = mnbService.GetExchangeRates(request);
            string result = response.GetExchangeRatesResult;
            return result;
        }

        private void LoadXml(string input) 
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(input);
            foreach (XmlElement item in xml.DocumentElement)
            {
                RateData r = new RateData();
                r.Date = DateTime.Parse(item.GetAttribute("date"));
                XmlElement child = (XmlElement)item.FirstChild;
                r.Currency = child.GetAttribute("curr");
                r.Value = decimal.Parse(child.InnerText);
                int unit = int.Parse(child.GetAttribute("unit"));
                if (unit!=0)
                    r.Value = r.Value / unit;
                Rates.Add(r);
            }

        }

        private void Charting()
        {
            chartRateData.DataSource = Rates;
            Series series = chartRateData.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 2;
        }
    }
}
