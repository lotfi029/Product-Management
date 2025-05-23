﻿using Microsoft.AspNetCore.Authorization;

namespace Store.Services.AuthAPI.Authentication.Filters;

public class PermissionRequirement(string permission) : IAuthorizationRequirement
{
    public string Permission { get; } = permission;

}