﻿using Domain.Entities.BaseClasses;
using Domain.Entities.Enums;
using Domain.Entities.Interfaces;

namespace Domain.Entities
{
    public class Questionnaire : IIdentifieble
    {
        public string Id { get; set; }
        public ICollection<Question> Questions { get; set; }
        public User Author { get; set; }
        public DateTime CreationDate { get; set; }
        public QuestionnaireState State { get; set; }
        public DateTime LastChangeDate { get; set; }
        public User LastChangedBy { get; set; }
    }
}
