package md5f1de3999714392015b12ca472ce4875b;


public class MyDialogFragment
	extends android.app.DialogFragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateDialog:(Landroid/os/Bundle;)Landroid/app/Dialog;:GetOnCreateDialog_Landroid_os_Bundle_Handler\n" +
			"n_onActivityCreated:(Landroid/os/Bundle;)V:GetOnActivityCreated_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Cheesesquare.MyDialogFragment, Cheesesquare, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MyDialogFragment.class, __md_methods);
	}


	public MyDialogFragment () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MyDialogFragment.class)
			mono.android.TypeManager.Activate ("Cheesesquare.MyDialogFragment, Cheesesquare, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public MyDialogFragment (int p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == MyDialogFragment.class)
			mono.android.TypeManager.Activate ("Cheesesquare.MyDialogFragment, Cheesesquare, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0 });
	}


	public android.app.Dialog onCreateDialog (android.os.Bundle p0)
	{
		return n_onCreateDialog (p0);
	}

	private native android.app.Dialog n_onCreateDialog (android.os.Bundle p0);


	public void onActivityCreated (android.os.Bundle p0)
	{
		n_onActivityCreated (p0);
	}

	private native void n_onActivityCreated (android.os.Bundle p0);

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
