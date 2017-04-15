﻿using System.Collections.Generic;
using System.Linq;
using SoftCinema.Data;
using SoftCinema.DTOs;
using SoftCinema.Models;

namespace SoftCinema.Services
{
    public static class ActorService
    {
        
        public static void AddActor(string name, float? rating)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Actor actor = new Actor()
                {
                    Name = name,
                    Rating = rating,
                };
                context.Actors.Add(actor);
                context.SaveChanges();
            }
        }

        public static void AddMovieToActor(string actorName, string movieName, int releaseYear)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Movie movie = context.Movies.FirstOrDefault(m => m.Name == movieName && m.ReleaseYear == releaseYear);
                Actor actor = context.Actors.FirstOrDefault(a => a.Name == actorName);
                actor.Movies.Add(movie);
                context.SaveChanges();
            }
        }
        public static List<Actor> GetAllActors ()
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Actors.ToList();
            }
        }
        public static bool IsActorExisting(string actorName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Actors.Any(a => a.Name == actorName);
            }
        }
    }
}
