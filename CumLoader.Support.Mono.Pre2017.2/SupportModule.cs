using System.Collections;
using UnityEngine;

namespace CumLoader.Support
{
    public class Module : ISupportModule
    {
        public int GetActiveSceneIndex() => Main.CurrentScene;
        public object StartCoroutine(IEnumerator coroutine)
        {
            if (Main.comp != null) return Main.comp.StartCoroutine(coroutine);

            CumLoaderComponent.QueuedCoroutines.Add(coroutine);
            return coroutine;
        }

        public void StopCoroutine(object coroutineToken)
        {
            if (Main.comp == null)
                CumLoaderComponent.QueuedCoroutines.Remove(coroutineToken as IEnumerator);
            else
                Main.comp.StopCoroutine(coroutineToken as Coroutine);
        }
        public void UnityDebugLog(string msg) => Debug.Log(msg);
        public void Destroy() => CumLoaderComponent.Destroy();
    }
}