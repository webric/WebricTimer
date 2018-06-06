﻿using System;
using System.Collections.Generic;

namespace WRT.Core.BLL
{
    partial class Competitor
    {
        public static Competitor Create(string number, string name)
        {
            var competitor = new Competitor
            {
                               Number = number,
                Name = name
            };

            if (DAL.Competitor.Create(competitor))
                return competitor;
            else
                return null;
        }

        public static bool Start(string raceSid, string competitorSid, DateTime time)
        {
            if (DAL.Competitor.Start(raceSid, competitorSid, time))
                return true;
            else
                return false;
        }

        public static bool Finnish(string raceSid, string competitorSid, DateTime time)
        {
            if (DAL.Competitor.Stop(raceSid, competitorSid, time))
                return true;
            else
                return false;
        }

        public static Competitor GetCompetitor(string competitorSid)
        {
            return DAL.Competitor.GetCompetitor(competitorSid);
        }

        public static List<Competitor> GetCompetitors(string raceSid)
        {
            return DAL.Competitor.GetCompetitors(raceSid);
        }
    }
}
