﻿using AlatAssessment.Application.Services.Interfaces;

namespace AlatAssessment.Application.Services.Implementations
{
    public class OtpService : IOtpService
    {
        private string otp = "546723";
        public string Otp { get => otp; }

        public string GenerateOtp()
        {
            //This implimentation would generate random 6 digits otp value. :)
            return Otp;
        }
    }
}
