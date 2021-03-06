﻿using System;

namespace UwpWeatherClient.Models
{
	public class WeatherListItem
	{
		public DateTime Time { get; set; }

		public double MinTemp { get; set; }
		public double MaxTemp { get; set; }
		public double DayTemp { get; set; }

		public string Description { get; set; }
		public double Humidity { get; set; }
		public double Pressure { get; set; }
		public int Clouds { get; set; }
		public double WindSpeed { get; set; }

		public string Icon { get; set; }
	}
}