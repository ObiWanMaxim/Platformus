﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Platformus.Barebone.Backend;
using Platformus.Globalization.Backend;
using Platformus.Globalization.Backend.ViewModels;

namespace Platformus.Forms.Backend.ViewModels.Forms
{
  public class CreateOrEditViewModel : ViewModelBase
  {
    public int? Id { get; set; }

    [Display(Name = "Code")]
    [Required]
    [StringLength(32)]
    public string Code { get; set; }

    [Multilingual]
    [Display(Name = "Name")]
    [Required]
    [StringLength(64)]
    public string Name { get; set; }
    public IEnumerable<Localization> NameLocalizations { get; set; }

    [Display(Name = "Email")]
    [Required]
    [StringLength(64)]
    public string Email { get; set; }

    [Display(Name = "Redirect URL")]
    [Required]
    [StringLength(128)]
    public string RedirectUrl { get; set; }
  }
}