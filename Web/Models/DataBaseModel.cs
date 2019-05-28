using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace Web.Models
{
    namespace DataAccessPostgreSqlProvider
    {
        public class AdaptiveApplicationDbContext : DbContext
        {
            public AdaptiveApplicationDbContext()
            { 
                Database.EnsureCreated();
            }

            public AdaptiveApplicationDbContext(DbContextOptions<AdaptiveApplicationDbContext> options) : base(options)
            {
            }

            public DbSet<DBAdaptive_educational_application> User { get; set; }

            public static string ConnectionString { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseNpgsql(ConnectionString);

                base.OnConfiguring(optionsBuilder);
            }
        }

        public class DBAdaptive_educational_application
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

            //public int Id { get; set; }

            /// <summary>
            /// предметные области
            /// </summary>
            /// <returns></returns>et; }
            /// <summary>
            /// картинка пользователя в соответствии с 
            //public DBSubject_Areas Subject_Areas { get; sего уровнем
            /// </summary>
            /// <returns></returns>
            public byte[] User_Picture { get; set; }
            /// <summary>
            /// Текущий уровень пользователя
            /// </summary>
            /// <returns></returns>
            public DBCurent_User_Level Curent_User_Level { get; set; }

            /// <summary>
            /// Жунрал пожеланий
            /// </summary>
            public virtual Collection<dbSuggestion_for_improvements> Journal { get; set; }

            //public dbSuggestion_for_improvements Suggestion_for_improvements { get; set; }
            public string UserName { get; set; }
            public int Traffic_Laws_Level { get; set; }
            public int Algebra_Level { get; set; }
            public int Geometry_Level { get; set; }
            public int Music_Level { get; set; }
            public int Curent_Level_User { get; set; }
        }

        ///// <summary>
        ///// Предметные области
        ///// </summary>
        //public enum DBSubject_Areas
        //{
        //    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //    /// <summary>
        //    /// Музыка
        //    /// </summary>
        //    Music,
        //    /// <summary>
        //    /// Алгебра
        //    /// </summary>
        //    Algebra,
        //    /// <summary>
        //    /// Геометрия
        //    /// </summary>
        //    Geometry,
        //    /// <summary>
        //    /// Правила дорожного движения (ПДД)
        //    /// </summary>
        //    Traffic_Laws,
        //}

        /// <summary>
        /// Текущий уровень пользователя складывается из уровней каждой предметной области
        /// </summary>
        public class DBCurent_User_Level
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Curent_Level_User { get; set; }
            /// <summary>
            /// Уровень пользователя в предметной области "Музыка"
            /// </summary>
            public int Music_Level { get; set; }
            /// <summary>
            /// Уровень пользователя в предметной области "Алгебра"
            /// </summary>
            public int Algebra_Level { get; set; }
            /// <summary>
            /// Уровень пользователя в предметной области "Геометрия"
            /// </summary>
            public int Geometry_Level { get; set; }
            /// <summary>
            /// Уровень пользователя в предметной области "ПДД"
            /// </summary>
            public int Traffic_Laws_Level { get; set; }
            /// <summary>
            /// Тема "музыка"
            /// </summary>
            public string Topic_Music { get; set; }
            /// <summary>
            /// Тема "алгебра"
            /// </summary>
            public string Topic_Algebra { get; set; }
            /// <summary>
            /// Тема "геометрия"
            /// </summary>
            public string Topic_Geometry { get; set; }
            /// <summary>
            /// Тема "ПДД"
            /// </summary>
            public string Topic_Traffic_Laws { get; set; }
        }

        [NotMapped]
        /// <summary>
        /// Добавление предложений по улучшению приложения
        /// </summary>
        public class dbSuggestion_for_improvements
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

            public virtual DBAdaptive_educational_application User { get; set; }
            /// <summary>
            /// Предметная область
            /// </summary>
            public string Subject_Area { get; set; }
            /// <summary>
            /// Пожелания
            /// </summary>
            public string Wishes { get; set; }
            /// <summary>
            /// Предложенная ссылка
            /// </summary>
            public string Proposed_link { get; set; }
            /// <summary>
            /// Что добавить в приложение
            /// </summary>
            public string Add_to_application { get; set; }

            public override string ToString()
            {
                return $"Предметная область: {Subject_Area}, Пожелания: {Wishes}, Предложенная ссылка: {Proposed_link}, Что добавить в приложение: {Add_to_application}";
            }
        }
    }
}
