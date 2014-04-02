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

    /*
     * Each question will have a string for the actual question, and an adjective for each answer.
     */

    public class Question
    {
        public Adjective answerA, answerB;
        public String question;

        public Question(String question, Adjective a, Adjective b)
        {
            this.answerA = a;
            this.answerB = b;
        }

    }

    /*
     * This will be a list of questions for the user to answer.
     */ 

    public class Quiz
    {
        public List<Question> QuizQuestions;
    }
}