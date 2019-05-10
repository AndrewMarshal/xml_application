using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptive_educational_application
{
    /// <summary>
    /// Адаптивное образовательное приложение
    /// </summary>
    public class Adaptive_educational_application
    {
        /// <summary>
        /// поле регистрации
        /// </summary>
        /// <returns></returns>
        public Registration Registration { get; set; }
        /// <summary>
        /// предметные области
        /// </summary>
        /// <returns></returns>
        public Subject_Areas Subject_Areas { get; set; }
        /// <summary>
        /// картинка пользователя в соответствии с его уровнем
        /// </summary>
        /// <returns></returns>
        public byte[] User_Picture { get; set; }
        /// <summary>
        /// Текущий уровень пользователя
        /// </summary>
        /// <returns></returns>
        public Curent_User_Level Curent_User_Level { get; set; }
        /// <summary>
        /// Ссылки на учебники
        /// </summary>
        public LinksTutorials LinksTutorials { get; set; }
        /// <summary>
        /// Жунрал пожеланий
        /// </summary>
        public List<Suggestion_for_improvements> Journal { get; set; }

        public Suggestion_for_improvements Suggestion_for_improvements { get; set;}
        public string UserName { get; set; }
        public int Traffic_Laws_Level { get; set; }
        public int Algebra_Level { get; set; }
        public int Geometry_Level { get; set; }
        public int Music_Level { get; set; }
        public int Curent_Level_User { get; set; }
    }

    /// <summary>
    /// Поле регистрации
    /// </summary>
    public class Registration
    {
        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Индивидуальный номер пользователя
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Дата рождения пользователя
        /// </summary>
        public DateTime birthDate { get; set; }
        /// <summary>
        /// Пол пользователя
        /// </summary>
        public bool UserGender { get; set; }
    }

    /// <summary>
    /// Предметные области
    /// </summary>
    public enum Subject_Areas
    {
        /// <summary>
        /// Музыка
        /// </summary>
        Music,
        /// <summary>
        /// Алгебра
        /// </summary>
        Algebra,
        /// <summary>
        /// Геометрия
        /// </summary>
        Geometry,
        /// <summary>
        /// Правила дорожного движения (ПДД)
        /// </summary>
        Traffic_Laws,
    }

    /// <summary>
    /// Текущий уровень пользователя складывается из уровней каждой предметной области
    /// </summary>
    public class Curent_User_Level
    {
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

    /// <summary>
    /// Ссылки на учебники
    /// </summary>
    public class LinksTutorials
    {
        /// <summary>
        /// Cсылка на музыку
        /// </summary>
        public string Url_Tutorials_Music { get; set; }
        /// <summary>
        /// Тема музыка
        /// </summary>
        public string Topic_Tutorials_Music { get; set; }
        /// <summary>
        /// Ссылка наа алгебру
        /// </summary>
        public string Url_Tutorials_Algebra { get; set; }
        /// <summary>
        /// Тема Алгебра
        /// </summary>
        public string Topic_Tutorials_Algebre { get; set; }
        /// <summary>
        /// Ссылка на геометрию
        /// </summary>
        public string Url_Tutorials_Geometry { get; set; }
        /// <summary>
        /// Тема Геометрия
        /// </summary>
        public string Topic_Tutorials_Geometry { get; set; }
        /// <summary>
        /// Ссылка на ПДД
        /// </summary>
        public string Url_Tutorials_Traffic_Laws { get; set; }
        /// <summary>
        /// Тема ПДД
        /// </summary>
        public string Topic_Tutorials_Traffic_Laws { get; set; }
    }

    /// <summary>
    /// Добавление предложений по улучшению приложения
    /// </summary>
    public class Suggestion_for_improvements
    {
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
