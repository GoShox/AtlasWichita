using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtlasWichita.Models
{
    public class Adjective
    {
        public String adjective;
        int formalValue;
        int conformistValue;
        int bluecollarValue;
        int simpleValue;
        int trendyValue;
        int grittyValue;
        int independentValue;
        int localValue;
        int energeticValue;
        int modernValue;
        int elegantValue;

        public Adjective(String s, int a, int b, int c, int d,
            int e, int f, int g, int h, int i, int j, int k) {
            this.adjective = s;
            this.formalValue = a;
            this.conformistValue = b;
            this.bluecollarValue = c;
            this.simpleValue = d;
            this.trendyValue = e;
            this.grittyValue = f;
            this.independentValue = g;
            this.localValue = h;
            this.energeticValue = i;
            this.modernValue = j;
            this.elegantValue = k;
        }
    }
}