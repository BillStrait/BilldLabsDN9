using Microsoft.AspNetCore.Components.Authorization;

namespace BilldLabsDN9.Client.Services
{
    public interface ICustomAuthenticationStateProvider
    {
        public Task<AuthenticationState> GetAuthenticationStateAsync();
        public void MarkUserAsAuthenticated(string token);
        public void MarkUserAsLoggedOut();

    }
}
