// ----------------------------------------------------------------------------------
// Microsoft Developer & Platform Evangelism
// 
// Copyright (c) Microsoft Corporation. All rights reserved.
// 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// ----------------------------------------------------------------------------------
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Augen_Quiz.Models
{
   public class TriviaContext : DbContext
    {
        public TriviaContext()
            : base("name=DefaultConnection")
        {
        }

        public DbSet<TriviaQuestion> TriviaQuestions { get; set; }
        public DbSet<TriviaOption> TriviaOptions { get; set; }
        public DbSet<TriviaAnswer> TriviaAnswers { get; set; }
    }

   public class TriviaDatabaseInitializer : DropCreateDatabaseAlways<TriviaContext>
   {
       protected override void Seed(TriviaContext context)
       {
           base.Seed(context);

           var questions = new List<TriviaQuestion>();

           questions.Add(new TriviaQuestion
           {
               Title = "When was Augen Software Group NZ founded?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "2003", IsCorrect= false },
                    new TriviaOption { Title= "1997", IsCorrect= false },
                    new TriviaOption { Title= "1993", IsCorrect= true },
                    new TriviaOption { Title= "2000", IsCorrect= false }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "Other than New Zealand, In which country does Augen has a office?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "USA", IsCorrect= false },
                    new TriviaOption { Title= "China", IsCorrect= false },
                    new TriviaOption { Title= "Australia", IsCorrect= false },
                    new TriviaOption { Title= "Vietnam", IsCorrect= true }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "When was Mike Hibbert join Augen?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "2001", IsCorrect= false },
                    new TriviaOption { Title= "2007", IsCorrect= false },
                    new TriviaOption { Title= "2011", IsCorrect= true },
                    new TriviaOption { Title= "2010", IsCorrect= false }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "When was Winston Chow join Augen?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "2005", IsCorrect= false },
                    new TriviaOption { Title= "2002", IsCorrect= false },
                    new TriviaOption { Title= "2003", IsCorrect= false },
                    new TriviaOption { Title= "2004", IsCorrect= true }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "How old is Peter Vile - CEO of Augen?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "16", IsCorrect= false },
                    new TriviaOption { Title= "21", IsCorrect= false },
                    new TriviaOption { Title= "25", IsCorrect= false },
                    new TriviaOption { Title= "Sh! Secret...", IsCorrect= true }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "When was Ricky Tang first join Augen?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "Aug, 2012", IsCorrect= false },
                    new TriviaOption { Title= "Jan, 2012", IsCorrect= false },
                    new TriviaOption { Title= "Nov, 2011", IsCorrect= true },
                    new TriviaOption { Title= "July, 2014", IsCorrect= false }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "Do you miss Ricky Tang?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "Never", IsCorrect= false },
                    new TriviaOption { Title= "Rarely", IsCorrect= false },
                    new TriviaOption { Title= "Yes! A lot!", IsCorrect= true },
                    new TriviaOption { Title= "No", IsCorrect= false }
                }).ToList()
           });

           questions.ForEach(a => context.TriviaQuestions.Add(a));

           context.SaveChanges();
       }
   }
}