﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PropertyChanged;
using Validar;

namespace ArkBot.Configuration.Model
{
    [AddINotifyPropertyChangedInterface]
    [InjectValidation]
    public class SslConfigSection
    {
        public SslConfigSection()
        {
            Domains = new List<string>();
        }

        public override string ToString() => $"SSL ({(Enabled ? "Enabled" : "Disabled")})";

        [JsonProperty(PropertyName = "enabled")]
        [Display(Name = "Enabled", Description = "Toggle ssl.")]
        public bool Enabled { get; set; }

        [JsonProperty(PropertyName = "challengeListenPrefix")]
        [Display(Name = "Challenge Listen Prefix", Description = "Http listen prefix for ssl challenge request (external port must be 80)")]
        public string ChallengeListenPrefix { get; set; }

        [JsonProperty(PropertyName = "name")]
        [Display(Name = "Name", Description = "Friendly name of the certificate")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "password")]
        [Display(Name = "Password", Description = "Private password")]
        public string Password { get; set; }

        [JsonProperty(PropertyName = "email")]
        [Display(Name = "Email", Description = "Registration contact email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "domains")]
        [Display(Name = "Domain name(s)", Description = "Domain name(s) to issue the certificate for")]
        public List<string> Domains { get; set; }

        [JsonProperty(PropertyName = "ports")]
        [Display(Name = "Ports", Description = "Ports to bind the ssl certificate to")]
        public int[] Ports { get; set; }

        [JsonProperty(PropertyName = "useCompatibilityNonSNIBindings")]
        [Display(Name = "Use Compatibility non-SNI Bindings", Description = "Use non SNI SSL bindings for previous Windows OS (before Windows 8/2012)")]
        public bool UseCompatibilityNonSNIBindings { get; set; }
    }
}
