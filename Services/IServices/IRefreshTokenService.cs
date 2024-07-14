namespace ApiNet8.Services.IServices
{
    public interface IRefreshTokenService
    {
        Task<string> RefreshTokenAsync(string expiredToken);
    }
}
