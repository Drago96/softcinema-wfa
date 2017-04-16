﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Data;
using SoftCinema.Models;

namespace SoftCinema.Services
{
    public static class ScreeningService
    {
        public static void AddScreening(int auditoriumId, int movieId, DateTime date)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Screening screening = new Screening()
                {
                    MovieId = movieId,
                    AuditoriumId = auditoriumId,
                    Start = date
                };
                context.Screenings.Add(screening);
                context.SaveChanges();
            }
        }

        public static bool IsScreeningExisting(int auditoriumId, DateTime date)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Screenings.Any(s => s.AuditoriumId == auditoriumId && s.Start == date);
            }
        }

        public static ICollection<Screening> GetScreenings(string townName, string cinemaName, string movieName)
        {
            using (var db = new SoftCinemaContext())
            {
                return db
                    .Screenings
                    .Where(s => s.Auditorium.Cinema.Name == cinemaName &&
                                s.Auditorium.Cinema.Town.Name == cinemaName &&
                                s.Movie.Name == movieName)
                    .ToList();
            }
        }

        public static string[] GetAllDates(string town, string cinema, string movie)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                var list = new List<string>();
                var dates =
                    context.Screenings.Where(
                        s =>
                            s.Movie.Name == movie && s.Auditorium.Cinema.Town.Name == town &&
                            s.Auditorium.Cinema.Name == cinema).Select(s => s.Start).ToArray();
                foreach (var dateTime in dates)
                {
                    var day = dateTime.Day.ToString();
                    var month = dateTime.ToString("MMM");
                    var weekDay = dateTime.DayOfWeek.ToString();
                    list.Add($"{day} {month} {weekDay}");
                }
                return list.Distinct().ToArray();
            }
        }

        public static string[] GetHoursForMoviesByDate(string town, string cinema, string movie, string date)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                var d = date.Split().ToArray();
                var day = d[0];
                var month = DateTime.ParseExact(d[1], "MMM", CultureInfo.CurrentCulture).Month.ToString();
                var list = new List<string>();
                var dates =
                    context.Screenings.Where(
                        s =>
                            s.Movie.Name == movie && s.Auditorium.Cinema.Town.Name == town &&
                            s.Auditorium.Cinema.Name == cinema && s.Start.Day.ToString() == day &&
                            s.Start.Month.ToString() == month).Select(s => s.Start).OrderBy(s => s.Hour).ToArray();

                foreach (var dateTime in dates)
                {
                    var hour = dateTime.ToString("hh");
                    var minutes = dateTime.ToString("mm");
                    var part = dateTime.ToString("tt", CultureInfo.InvariantCulture);
                    list.Add($"{hour}:{minutes} {part}");
                }
                return list.Distinct().ToArray();
            }
        }

        public static Screening GetScreening(string townName, string cinemaName, string movieName, DateTime date)
        {
            using (var db = new SoftCinemaContext())
            {
                return
                    db.Screenings
                    .Include("Auditorium")
                    .Include("Auditorium.Seats")
                    .Include("Movie")
                    .Include("Tickets")
                    .FirstOrDefault(
                        s => s.Movie.Name == movieName &&
                             s.Start == date &&
                             s.Auditorium.Cinema.Town.Name == townName &&
                             s.Auditorium.Cinema.Name == cinemaName);
            }
        }
    }
}