﻿namespace HomeBudget.Domain
{
    public class User : BaseEntityWithId
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
