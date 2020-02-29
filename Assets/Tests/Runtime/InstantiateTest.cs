using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
	public class InstantiateTest
	{
		[Test]
		public void InstantiatedGameObject()
		{
			var go = new GameObject("MyGameObject");
			Assert.AreEqual("MyGameObject", go.name);
		}

		[UnityTest]
		public IEnumerator InstantiateGameObjectWithEnumerator()
		{
			var go = new GameObject("MyGameObject");
			go.AddComponent<Rigidbody>();
			var originalPosition = go.transform.position.y;
            
			yield return new WaitForFixedUpdate();
            
			Assert.AreNotEqual(originalPosition, go.transform.position.y);
		}
        
	}
}