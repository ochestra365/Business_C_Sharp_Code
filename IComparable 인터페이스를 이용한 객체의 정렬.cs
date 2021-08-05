using System;
using System.Collections.Generic;
using System.Text;

namespace GIT에_올릴_업무코드
{
    class IComparable_인터페이스를_이용한_객체의_정렬
    {
        class Artists : IComparable
        {
            public string Name { get; set; }
            public string Country { get; set; }
            public int Birth { get; set; }
            public int Die { get; set; }
            public Artists(string name, string country, int birth, int die)
            {
                Name = name;
                Country = country;
                Birth = birth;
                Die = die;
            }
            public int CompareTo(object obj)
            {
                Artists a = (Artists)obj;
                return this.Birth.CompareTo(a.Birth);//obj캐스팅 이후 Birth랑 비교
            }
            public override string ToString()
            {
                return string.Format($"{Name}, {Country}, {Birth}, {Die}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Artists[] famousArtists = {
                new Artists("레오나르도 다빈치","이탈리아",1452,1519),
                new Artists("빈센트 반 고흐","네덜란드",1853,1890),
                new Artists("클로드 모네","프랑스",1840,1926),
                new Artists("파블로 피카소","스페인",1881,1973),
                new Artists("베르메르","네덜란드",1632,1675),
                new Artists("르노아르","프랑스",1841,1919),
        };
                List<Artists> artist19C = new List<Artists>();
                foreach (var artist in famousArtists)
                {
                    if (artist.Birth > 1800 && artist.Birth <= 1900) artist19C.Add(artist);
                }
                //IComparable를 사용하여 정렬
                artist19C.Sort();
                Console.WriteLine("19세기 미술가를 탄생 순 정렬: IComparable");
                foreach (var a in artist19C) Console.WriteLine(a.ToString());
            }
        }
    }
}
