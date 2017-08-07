﻿#region Copyright
// /************************************************************************
//    Copyright (c) 2017 Jamie Rees
//    File: Users.cs
//    Created By: Jamie Rees
//   
//    Permission is hereby granted, free of charge, to any person obtaining
//    a copy of this software and associated documentation files (the
//    "Software"), to deal in the Software without restriction, including
//    without limitation the rights to use, copy, modify, merge, publish,
//    distribute, sublicense, and/or sell copies of the Software, and to
//    permit persons to whom the Software is furnished to do so, subject to
//    the following conditions:
//   
//    The above copyright notice and this permission notice shall be
//    included in all copies or substantial portions of the Software.
//   
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
//    MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//    NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
//    LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
//    OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
//    WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//  ************************************************************************/
#endregion

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using Newtonsoft.Json;
using Ombi.Helpers;


namespace Ombi.Store.Entities
{
    //public class User : Entity
    //{
    //    public string Username { get; set; }
    //    public string Alias { get; set; }
    //    public string ClaimsSerialized { get; set; }
    //    public string EmailAddress { get; set; }
    //    public string Password { get; set; }
    //    public byte[] Salt { get; set; }
    //    public UserType UserType { get; set; }

    //    [NotMapped]
    //    public string UserAlias => string.IsNullOrEmpty(Alias) ? Username : Alias;

    //    [NotMapped]
    //    public List<Claim> Claims {
    //        get => JsonConvert.DeserializeObject<List<Claim>>(ClaimsSerialized, new ClaimConverter());
    //        set => ClaimsSerialized = JsonConvert.SerializeObject(value, new ClaimConverter());
    //    }
    //}

    public enum UserType
    {
        LocalUser = 1,
        PlexUser = 2,
        EmbyUser = 3,
    }
}