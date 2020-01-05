package crc648a6e52481296c552;


public class RadioButtonRenderer
	extends crc643f46942d9dd1fff9.ViewRenderer_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("XamarinFormApp.Droid.Renderer.RadioButtonRenderer, XamarinFormApp.Android", RadioButtonRenderer.class, __md_methods);
	}


	public RadioButtonRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == RadioButtonRenderer.class)
			mono.android.TypeManager.Activate ("XamarinFormApp.Droid.Renderer.RadioButtonRenderer, XamarinFormApp.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public RadioButtonRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == RadioButtonRenderer.class)
			mono.android.TypeManager.Activate ("XamarinFormApp.Droid.Renderer.RadioButtonRenderer, XamarinFormApp.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public RadioButtonRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == RadioButtonRenderer.class)
			mono.android.TypeManager.Activate ("XamarinFormApp.Droid.Renderer.RadioButtonRenderer, XamarinFormApp.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
