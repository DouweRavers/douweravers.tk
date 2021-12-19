static class Global
{
	#region 
#if !UNITY_EDITOR && UNITY_WEBGL
    [System.Runtime.InteropServices.DllImport("__Internal")]
    private static extern bool IsMobile();
#endif
	public static bool isMobile
	{
		get
		{
#if !UNITY_EDITOR && UNITY_WEBGL
			return IsMobile();
#endif
			return DEBUG.isMobile;
		}
	}
	#endregion
}

static class DEBUG
{
	public static bool isMobile = false;

}