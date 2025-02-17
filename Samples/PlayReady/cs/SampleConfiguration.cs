//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace SDKTemplate
{
    public partial class MainPage : Page
    {
        public const string FEATURE_NAME = "PlayReady C# Sample";

        List<Scenario> scenarios = new List<Scenario>
        {
            new Scenario() { Title="Reactive License Request", ClassType=typeof(Scenario1_ReactiveRequest)},
            new Scenario() { Title="Proactive License Request", ClassType=typeof(Scenario2_ProactiveRequest)},
            new Scenario() { Title="Manage HW/SW DRM", ClassType=typeof(Scenario3_HardwareDRM)},
            new Scenario() { Title="Secure Stop", ClassType=typeof(Scenario4_SecureStop)}
        };

  //      public static string SampleMovieURL = "https://10.3.2.154/video/xbox/playready_20250214104307/stream.mpd";
        public static string SampleMovieURL = "http://10.0.16.90:8080/stream.mpd";
        public static string HeaderToken = "nv-authorizations";
        public static string Token = "eyJraWQiOiI2MDkwOTUiLCJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ2ZXIiOiIxLjAiLCJ0eXAiOiJDb250ZW50QXV0aFoiLCJqdGkiOiI4YmE1YjhiOS1kYTU1LTQ5MmYtYjhjNC1kNDI1ZWZiNTQ0NDEiLCJjb250ZW50UmlnaHRzIjpbeyJjb250ZW50SWQiOiJDb250ZW50SWQgIzEiLCJlbmNyeXB0aW9uTWV0aG9kIjoiUkFXX0FFU18xMjhfQ1RSX0NFTkMiLCJ1c2FnZVJ1bGVzUHJvZmlsZUlkIjoiVGVzdCIsImRlZmF1bHRLY0lkcyI6WyJmZmZmZmZmZi1hYWFhLWJiYmItMDAwMS0wMDAwMDAwMDAwMDEiXX1dfQ.ba0pXOX3rqXTEJdZZ1vyAdjVrlQ9HB1b1qy7zvwHCPA,eyJrY0lkcyI6WyJmZmZmZmZmZi1hYWFhLWJiYmItMDAwMS0wMDAwMDAwMDAwMDEiXSwidHlwIjoiSldUIiwiZW5jIjoiQTEyOENCQy1IUzI1NiIsImFsZyI6ImRpciIsImtpZCI6IjY4OTM1NCJ9..oFS5ie4LlXsYnydrSEgHOw.GHS4QfhLWetrSmGJl5PLfnx9yf-Rmhv2GuZxhxiQTR8oc80yUMI17KlIWk7hNZnX5QrMCqrZDbm4P-F0SMurDIX43PMutTBflK0msC6oGnbetWiOgBFUG0-RkY2fDMkq9F8wzPdaOLHQwNdvBT9BZDLxraCti72DfIoTUuliNjQ.qluxfXXjMROQLB66eVCcrA";
        public static string LicenceURL = "https://cl11.anycast.nagra.com/PLAYREADY/prls/contentlicenseservice/v1/licenses";
        public static string TenantId = "PLAYREADY";
        public static string Placeholder = "https://10.3.2.154/video/xbox/playready_20250213034403/playready_20250213034403/stream.mpd";



    }

    public class Scenario
    {
        public string Title { get; set; }
        public Type ClassType { get; set; }
    }
}
