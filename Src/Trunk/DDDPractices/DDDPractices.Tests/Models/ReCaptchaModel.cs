using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DDDPractices.Tests.Models
{
    public class ReCaptchaModel
    {

        [JsonProperty("success")]
        public bool Success { get; set; }
        [JsonProperty("challenge_ts")]
        public DateTime ChallengeTs { get; set; }
        [JsonProperty("hostname")]
        public string HostName { get; set; }
        [JsonProperty("score")]
        public decimal Score { get; set; }
        [JsonProperty("action")]
        public string Action { get; set; }
        [JsonProperty("error-codes")]
        public List<string> ErrorCodes { get; set; }
        
        
        
        
        
        
        
        
    }
}