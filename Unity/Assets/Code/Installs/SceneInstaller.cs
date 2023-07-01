using Code.Configs;
using Code.Providers;
using Code.Services;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class SceneInstaller : LifetimeScope
{
    [SerializeField] private CarProvider _carProvider;
    [SerializeField] private CarConfig _carConfig;
    [SerializeField] private UIProvider _uiProvider;
    
    protected override void Configure(IContainerBuilder builder)
    {
        RegisterProviders(builder);
        RegisterServices(builder);
        RegisterConfigs(builder);
    }

    private void RegisterConfigs(IContainerBuilder builder)
    {
        builder.RegisterInstance(_carConfig);
    }

    private void RegisterServices(IContainerBuilder builder)
    {
        builder.RegisterEntryPoint<InputService>(Lifetime.Scoped).AsSelf();
        builder.RegisterEntryPoint<MoveService>(Lifetime.Scoped);
    }

    private void RegisterProviders(IContainerBuilder builder)
    {
        builder.RegisterComponent(_carProvider);
        builder.RegisterComponent(_uiProvider);
    }
}
