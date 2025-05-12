using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using HotelProjectWebUI.Dtos.FollowersDto;
using Newtonsoft.Json;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Org.BouncyCastle.Asn1.Ocsp;

namespace HotelProjectWebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ResultInstagramFollowersDto result = null;
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-scraper-20251.p.rapidapi.com/userinfo/?username_or_id=murattycedag"),
                Headers =
    {
        { "x-rapidapi-key", "20f4234472msh6f1aa5d52c53782p16454fjsnf3b656456ff4" },
        { "x-rapidapi-host", "instagram-scraper-20251.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                ViewBag.v1 = result.data.follower_count;
                ViewBag.v2 = result.data.following_count;
             
            }



            ResultTwitterFollowersDto result2= null;
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter154.p.rapidapi.com/user/details?username=omarmhaimdat&user_id=96479162"),
                Headers =
    {
        { "x-rapidapi-key", "20f4234472msh6f1aa5d52c53782p16454fjsnf3b656456ff4" },
        { "x-rapidapi-host", "twitter154.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body = await response2.Content.ReadAsStringAsync();

                result2 = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body);
                ViewBag.t1 = result2.follower_count;
                ViewBag.t2 = result2.following_count;
          
            }


            // LinkedIn
            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fnarin-ulu%25C4%25B1%25C5%259F%25C4%25B1k-aa7758246%2F&include_skills=false&include_certifications=false&include_publications=false&include_honors=false&include_volunteers=false&include_projects=false&include_patents=false&include_courses=false&include_organizations=false&include_profile_status=false&include_company_public_url=false"),
                Headers =
                {
                    { "x-rapidapi-key", "20f4234472msh6f1aa5d52c53782p16454fjsnf3b656456ff4" },
                    { "x-rapidapi-host", "fresh-linkedin-profile-data.p.rapidapi.com" },
                },
            };

            var response3 = await client3.SendAsync(request3);
            response3.EnsureSuccessStatusCode();
            var body3 = await response3.Content.ReadAsStringAsync();
            var resultLinkedin = JsonConvert.DeserializeObject<ResultLinkedinFolloweersDto>(body3);
            ViewBag.l1 = resultLinkedin.data.follower_count;
            ViewBag.l2 = resultLinkedin.data.connection_count;

            return View();
        }
    }
}
