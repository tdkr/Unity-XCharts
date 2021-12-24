
using System;
using UnityEngine;

namespace XCharts
{
    [Serializable]
    [SerieHandler(typeof(LineHandler), true)]
    [SerieConvert(typeof(Bar), typeof(Pie))]
    [CoordOptions(typeof(GridCoord), typeof(PolarCoord))]
    [DefaultAnimation(AnimationType.LeftToRight)]
    public class Line : Serie, INeedSerieContainer
    {
        public int containerIndex { get; internal set; }
        public int containterInstanceId { get; internal set; }
        public static void AddDefaultSerie(BaseChart chart, string serieName)
        {
            var serie = chart.AddSerie<Line>(serieName);
            serie.symbol.show = true;
            serie.label.offset = new Vector3(0, 15f, 0);
            serie.label.autoOffset = true;
            for (int i = 0; i < 5; i++)
            {
                chart.AddData(serie.index, UnityEngine.Random.Range(10, 90));
            }
        }

        public static Line CovertSerie(Serie serie)
        {
            var newSerie = serie.Clone<Line>();
            return newSerie;
        }
    }
}