using TZ;
using UnityEngine;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    [SerializeField] private PlayerStats _playerConfig;
    
    [SerializeField] private Parachute _parachuteConfig;
    [SerializeField] private RocketPack _rocketPackConfig;
    [SerializeField] private Weapon _weaponConfig;
    
    public override void InstallBindings()
    {
        Container
            .BindInterfacesTo<Equipment>()
            .AsSingle()
            .NonLazy();
        
        Container
            .BindInterfacesAndSelfTo<Player>()
            .AsSingle()
            .WithArguments(
                _playerConfig.Health,
                _playerConfig.Lives,
                _playerConfig.Nickname,
                _playerConfig.Skills,
                new Equipment()
                );
        
        Container
            .Bind<Parachute>()
            .FromInstance(_parachuteConfig);
        
        Container
            .Bind<RocketPack>()
            .FromInstance(_rocketPackConfig);
        
        Container
            .Bind<Weapon>()
            .FromInstance(_weaponConfig);
    }
}