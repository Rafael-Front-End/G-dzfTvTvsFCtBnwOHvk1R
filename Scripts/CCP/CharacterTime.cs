using UnityEngine;

namespace Assets.Character_Controller_Pro.Core.Scripts.Utilities
{
    public class CharacterTime : MonoBehaviour
    {
        public static CharacterTime Instance
        {
            get; private set;
        }

        void Start()
        {
            Instance = this;
        }

        public virtual float timeScale { get => Time.timeScale; }
        public virtual float deltaTime { get => Time.deltaTime; }
        public virtual float time { get => CharacterTimeGlobal.time; }
    }

    public class CharacterTimeGlobal
    {
        public static float timeScale { get => CharacterTime.Instance.timeScale; }
        public static float time { get => CharacterTime.Instance.time; }
        public static float deltaTime { get => CharacterTime.Instance.deltaTime; }
    }
}