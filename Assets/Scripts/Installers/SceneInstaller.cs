using TZ;
using UnityEngine;
using Zenject;

namespace TZ
{
    public class SceneInstaller : MonoInstaller
    {
        // Добавление конфига статов плеера, чтобы на их основе создать экземпляр 
        [SerializeField] private PlayerStats _playerConfig;

        public override void InstallBindings()
        {
            //Зарегистрировал класс, чтобы через DI к нему могли обращаться другие классы
            // Сразу создал экземпляр клааса в единсвенном виде
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
        }
    }
}