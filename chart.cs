            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Titles.Clear();

            Title title1 = new Title("Title1");

            // series
            Random rdm = new Random();
            Series seriesLine = new Series();
            seriesLine.ChartType = SeriesChartType.Line;
            seriesLine.LegendText = "Legend:Line";
            seriesLine.BorderWidth = 2;
            seriesLine.MarkerStyle = MarkerStyle.None;
            seriesLine.MarkerSize = 12;
            int m = 0;
            for (int i = 0; i < 30; i++)
            {
                seriesLine.Points.Add(new DataPoint(i, m += rdm.Next(-100, 110)));
            }

            Series seriesLine2 = new Series();
            seriesLine2.ChartType = SeriesChartType.Line;
            seriesLine2.LegendText = "Legend:Line2";
            //seriesLine2.BorderWidth = 2;
            seriesLine2.Color = Color.Red;
            m = 0;
            for (int i = 0; i < 30; i++)
            {
                seriesLine2.Points.Add(new DataPoint(i, m += rdm.Next(-100, 110)));
            }
           
            // chartarea
            ChartArea area1 = new ChartArea();
            area1.AxisX.Title = "Title-XAxis";
            area1.AxisY.Title = "Title-YAxis";

            chart1.Titles.Add(title1);
            chart1.ChartAreas.Add(area1);
            chart1.Series.Add(seriesLine);
            chart1.Series.Add(seriesLine2);
