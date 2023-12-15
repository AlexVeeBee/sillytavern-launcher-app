namespace st_installer_launcher.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
