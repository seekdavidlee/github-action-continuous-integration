using MyWebApi;

namespace MyWebApiTest
{
	[TestClass]
	public class WeatherForecastServiceTests : IDisposable
	{
		private readonly WeatherForecastService _weatherForecastService = new WeatherForecastService();

		[TestMethod]
		public void AddDuplicateDate_ResultInApplicationEx()
		{
			_weatherForecastService.Add(new WeatherForecast { Date = DateTime.Today, Temp = 10 });
			Assert.ThrowsException<ApplicationException>(() =>
			{
				_weatherForecastService.Add(new WeatherForecast { Date = DateTime.Today, Temp = 20 });
			});
		}

		[TestMethod]
		public void AddHighTemp_ResultInApplicationEx()
		{
			Assert.ThrowsException<ApplicationException>(() =>
			{
				_weatherForecastService.Add(new WeatherForecast { Date = DateTime.Today, Temp = 201 });
			});
		}

		[TestMethod]
		public void AddLowTemp_ResultInApplicationEx()
		{
			Assert.ThrowsException<ApplicationException>(() =>
			{
				_weatherForecastService.Add(new WeatherForecast { Date = DateTime.Today, Temp = -201 });
			});
		}

		[TestMethod]
		public void AddRightTemp_NoException()
		{
			_weatherForecastService.Add(new WeatherForecast { Date = DateTime.Today, Temp = 200 });
		}

		[TestMethod]
		public void AddTempForTwoDiffDates_NoException()
		{
			_weatherForecastService.Add(new WeatherForecast { Date = DateTime.Today.AddDays(-9), Temp = 80 });
			_weatherForecastService.Add(new WeatherForecast { Date = DateTime.Today.AddDays(-8), Temp = 90 });
		}

		public void Dispose()
		{
			_weatherForecastService.Clear();
		}
	}
}