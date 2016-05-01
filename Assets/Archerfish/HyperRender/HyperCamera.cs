using UnityEngine;
using System.Collections;

public class HyperCamera : MonoBehaviour
{
	public int SpaceSliceCount = 3;

	public GameObject CameraPrefab = null;

	public void Start()
	{
		for (int sliceIndex = 0;
			sliceIndex < SpaceSliceCount;
			++sliceIndex)
		{
			GameObject sliceCameraObject = GameObject.Instantiate(CameraPrefab);

			Camera sliceCameraComponent = sliceCameraObject.GetComponent<Camera>();

			RenderTexture sliceTexture = 
				new RenderTexture(
					sliceCameraComponent.pixelWidth,
					sliceCameraComponent.pixelHeight,
					depth: 24);

			sliceCameraComponent.targetTexture = sliceTexture;
		}
	}
}

