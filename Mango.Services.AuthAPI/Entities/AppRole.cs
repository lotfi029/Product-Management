﻿using Microsoft.AspNetCore.Identity;

namespace Store.Services.AuthAPI.Entities;

public class AppRole : IdentityRole
{
    public bool IsDisable { get; set; }
}
