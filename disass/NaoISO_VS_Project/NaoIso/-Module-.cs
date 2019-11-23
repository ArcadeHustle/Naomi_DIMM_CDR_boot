using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using <CppImplementationDetails>;
using <CrtImplementationDetails>;
using NaoIso;
using vc_attributes;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000001 RID: 1 RVA: 0x0000C56C File Offset: 0x0000B96C
	internal static void ??__E?A0x250abb45@SA_Yes@@YMXXZ()
	{
		<Module>.?A0x250abb45.SA_Yes = (YesNoMaybe)268370176;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x0000C584 File Offset: 0x0000B984
	internal static void ??__E?A0x250abb45@SA_No@@YMXXZ()
	{
		<Module>.?A0x250abb45.SA_No = (YesNoMaybe)268369921;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x0000C59C File Offset: 0x0000B99C
	internal static void ??__E?A0x250abb45@SA_Maybe@@YMXXZ()
	{
		<Module>.?A0x250abb45.SA_Maybe = (YesNoMaybe)268369936;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x0000C5B4 File Offset: 0x0000B9B4
	internal static void ??__E?A0x250abb45@SA_NoAccess@@YMXXZ()
	{
		<Module>.?A0x250abb45.SA_NoAccess = (AccessType)0;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000C5C8 File Offset: 0x0000B9C8
	internal static void ??__E?A0x250abb45@SA_Read@@YMXXZ()
	{
		<Module>.?A0x250abb45.SA_Read = (AccessType)1;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x0000C5DC File Offset: 0x0000B9DC
	internal static void ??__E?A0x250abb45@SA_Write@@YMXXZ()
	{
		<Module>.?A0x250abb45.SA_Write = (AccessType)2;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x0000C5F0 File Offset: 0x0000B9F0
	internal static void ??__E?A0x250abb45@SA_ReadWrite@@YMXXZ()
	{
		<Module>.?A0x250abb45.SA_ReadWrite = (AccessType)3;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x0000C604 File Offset: 0x0000BA04
	internal static void ??__E?A0x250abb45@_HUGE@@YMXXZ()
	{
		<Module>.?A0x250abb45._HUGE = double.PositiveInfinity;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x0000C6AC File Offset: 0x0000BAAC
	internal static void ??__E?A0x250abb45@HUGE@@YMXXZ()
	{
		<Module>.?A0x250abb45.HUGE = <Module>.?A0x250abb45._HUGE;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x000024CC File Offset: 0x000018CC
	internal static ref char PtrToStringChars(string s)
	{
		ref byte ptr = s;
		if (ref ptr != null)
		{
			ptr = RuntimeHelpers.OffsetToStringData + ref ptr;
		}
		return ref ptr;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x0000C620 File Offset: 0x0000BA20
	internal static void ??__E?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA@@YMXXZ()
	{
		<Module>.?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA = 0;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x0000C634 File Offset: 0x0000BA34
	internal static void ??__E?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA@@YMXXZ()
	{
		<Module>.?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA = 0;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x0000C648 File Offset: 0x0000BA48
	internal static void ??__E?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA@@YMXXZ()
	{
		<Module>.?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA = false;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x0000C65C File Offset: 0x0000BA5C
	internal static void ??__E?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (Progress.State)0;
	}

	// Token: 0x0600000F RID: 15 RVA: 0x0000C670 File Offset: 0x0000BA70
	internal static void ??__E?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		<Module>.?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (Progress.State)0;
	}

	// Token: 0x06000010 RID: 16 RVA: 0x0000C684 File Offset: 0x0000BA84
	internal static void ??__E?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		<Module>.?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (Progress.State)0;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x0000C698 File Offset: 0x0000BA98
	internal static void ??__E?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		<Module>.?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (Progress.State)0;
	}

	// Token: 0x06000012 RID: 18 RVA: 0x0000276C File Offset: 0x00001B6C
	internal unsafe static <CrtImplementationDetails>.ActivationContext* <CrtImplementationDetails>.ActivationContext.{ctor}(<CrtImplementationDetails>.ActivationContext* A_0)
	{
		*A_0 = -1;
		*(A_0 + 4) = 0;
		<Module>.gcroot<System::String\u0020^>.{ctor}(A_0 + 8);
		return A_0;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x000028CC File Offset: 0x00001CCC
	internal unsafe static void <CrtImplementationDetails>.ActivationContext.{dtor}(<CrtImplementationDetails>.ActivationContext* A_0)
	{
		try
		{
			<Module>.<CrtImplementationDetails>.ActivationContext.Release(A_0);
		}
		catch
		{
			<Module>.___CxxCallUnwindDtor(ldftn(gcroot<System::String\u0020^>.{dtor}), A_0 + 8);
			throw;
		}
		<Module>.gcroot<System::String\u0020^>.{dtor}(A_0 + 8);
	}

	// Token: 0x06000014 RID: 20 RVA: 0x000024E8 File Offset: 0x000018E8
	internal unsafe static void <CrtImplementationDetails>.ActivationContext.Create(<CrtImplementationDetails>.ActivationContext* A_0)
	{
		if (*A_0 == -1 && <Module>.GetProcAddress(<Module>.GetModuleHandleW((char*)(&<Module>.??_C@_1BC@EKMDCNOB@?$AAK?$AAE?$AAR?$AAN?$AAE?$AAL?$AA3?$AA2?$AA?$AA@)), (sbyte*)(&<Module>.??_C@_0O@JKAFBCMB@CreateActCtxW?$AA@)) != null)
		{
			bool flag = false;
			string text = Assembly.GetCallingAssembly().Location;
			try
			{
				if (text == "")
				{
					string tempFileName = Path.GetTempFileName();
					StreamWriter streamWriter = File.CreateText(tempFileName);
					streamWriter.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>\n<assembly xmlns=\"urn:schemas-microsoft-com:asm.v1\" manifestVersion=\"1.0\">\n   <dependency>\n       <dependentAssembly>\n           <assemblyIdentity\n               type='win32'\n               name='Microsoft.VC90.CRT'\n               version='9.0.21022.8'\n               processorArchitecture='x86'\n               publicKeyToken='1fc8b3b9a1e18e3b'/>\n       </dependentAssembly>\n   </dependency>\n</assembly>\n");
					streamWriter.Close();
					flag = true;
					text = tempFileName;
				}
				ref char char_u0020modopt(IsConst)& = ref <Module>.PtrToStringChars(text);
				try
				{
					tagACTCTXW tagACTCTXW;
					*(ref tagACTCTXW + 12) = 0;
					*(ref tagACTCTXW + 14) = 0;
					*(ref tagACTCTXW + 16) = 0;
					*(ref tagACTCTXW + 24) = 0;
					*(ref tagACTCTXW + 28) = 0;
					tagACTCTXW = 32;
					*(ref tagACTCTXW + 8) = ref char_u0020modopt(IsConst)&;
					if (flag)
					{
						*(ref tagACTCTXW + 20) = 0;
						*(ref tagACTCTXW + 4) = 0;
					}
					else
					{
						*(ref tagACTCTXW + 20) = 2;
						*(ref tagACTCTXW + 4) = 8;
					}
					void* ptr = <Module>.CreateActCtxW((tagACTCTXW*)(&tagACTCTXW));
					*A_0 = ptr;
					if (ptr == -1)
					{
						if (!flag)
						{
							*(ref tagACTCTXW + 20) = 1;
							*A_0 = <Module>.CreateActCtxW((tagACTCTXW*)(&tagACTCTXW));
						}
					}
				}
				catch
				{
					throw;
				}
			}
			finally
			{
				if (flag)
				{
					File.Delete(text);
				}
			}
		}
	}

	// Token: 0x06000015 RID: 21 RVA: 0x0000261C File Offset: 0x00001A1C
	internal unsafe static void <CrtImplementationDetails>.ActivationContext.Activate(<CrtImplementationDetails>.ActivationContext* A_0)
	{
		uint num = (uint)(*A_0);
		if (num != 4294967295u)
		{
			<Module>.ActivateActCtx(num, A_0 + 4);
		}
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002790 File Offset: 0x00001B90
	internal unsafe static void <CrtImplementationDetails>.ActivationContext.DeActivate(<CrtImplementationDetails>.ActivationContext* A_0)
	{
		if (*A_0 != -1)
		{
			uint num = (uint)(*(A_0 + 4));
			if (num != 0u)
			{
				uint num2 = num;
				*(A_0 + 4) = 0;
				if (<Module>.DeactivateActCtx(0, num2) == null)
				{
					<CrtImplementationDetails>.ActivationContext* ptr = A_0 + 8;
					<Module>.gcroot<System::String\u0020^>.=(ptr, "The C++ module failed to Deactivate WinSXS Activation Context.\n");
					<Module>.<CrtImplementationDetails>.ThrowModuleLoadException(<Module>.gcroot<System::String\u0020^>..P$AAVString@System@@(ptr));
				}
			}
		}
	}

	// Token: 0x06000017 RID: 23 RVA: 0x000027D8 File Offset: 0x00001BD8
	internal unsafe static void <CrtImplementationDetails>.ActivationContext.Release(<CrtImplementationDetails>.ActivationContext* A_0)
	{
		if (*A_0 != -1)
		{
			<Module>.<CrtImplementationDetails>.ActivationContext.DeActivate(A_0);
			<Module>.ReleaseActCtx(*A_0);
			*A_0 = -1;
		}
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000027FC File Offset: 0x00001BFC
	[DebuggerStepThrough]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeVtables(LanguageSupport* A_0)
	{
		<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during vtable initialization.\n");
		<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (Progress.State)1;
		<Module>._initterm_m((method*)(&<Module>.?A0x250abb45.__xi_vt_a), (method*)(&<Module>.?A0x250abb45.__xi_vt_z));
		<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (Progress.State)2;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002830 File Offset: 0x00001C30
	[DebuggerStepThrough]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializePerAppDomain(LanguageSupport* A_0)
	{
		<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during appdomain initialization.\n");
		<Module>.?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (Progress.State)1;
		<Module>._initatexit_app_domain();
		<Module>._initterm_m((method*)(&<Module>.?A0x250abb45.__xc_ma_a), (method*)(&<Module>.?A0x250abb45.__xc_ma_z));
		<Module>.?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (Progress.State)2;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x0000286C File Offset: 0x00001C6C
	[DebuggerStepThrough]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeUninitializer(LanguageSupport* A_0)
	{
		<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during registration for the unload events.\n");
		<Module>.<CrtImplementationDetails>.RegisterModuleUninitializer(new EventHandler(<Module>.<CrtImplementationDetails>.LanguageSupport.DomainUnload));
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002914 File Offset: 0x00001D14
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[DebuggerStepThrough]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport._Initialize(LanguageSupport* A_0)
	{
		<CrtImplementationDetails>.ActivationContext activationContext;
		<Module>.<CrtImplementationDetails>.ActivationContext.{ctor}(ref activationContext);
		try
		{
			<Module>.<CrtImplementationDetails>.ActivationContext.Create(ref activationContext);
			<Module>.<CrtImplementationDetails>.ActivationContext.Activate(ref activationContext);
			<Module>.clock();
			<Module>.?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA = AppDomain.CurrentDomain.IsDefaultAppDomain();
			<Module>.<CrtImplementationDetails>.DoDllLanguageSupportValidation();
			<Module>.<CrtImplementationDetails>.LanguageSupport.InitializeVtables(A_0);
			<Module>.<CrtImplementationDetails>.ActivationContext.DeActivate(ref activationContext);
			<Module>.<CrtImplementationDetails>.ActivationContext.Release(ref activationContext);
			<Module>.<CrtImplementationDetails>.LanguageSupport.InitializePerAppDomain(A_0);
			<Module>.?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA = 1;
			<Module>.<CrtImplementationDetails>.LanguageSupport.InitializeUninitializer(A_0);
		}
		catch
		{
			<Module>.___CxxCallUnwindDtor(ldftn(<CrtImplementationDetails>.ActivationContext.{dtor}), (void*)(&activationContext));
			throw;
		}
		<Module>.<CrtImplementationDetails>.ActivationContext.{dtor}(ref activationContext);
	}

	// Token: 0x0600001C RID: 28 RVA: 0x0000263C File Offset: 0x00001A3C
	internal static void <CrtImplementationDetails>.LanguageSupport.UninitializeAppDomain()
	{
		<Module>._app_exit_callback();
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002650 File Offset: 0x00001A50
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[PrePrepareMethod]
	internal static void <CrtImplementationDetails>.LanguageSupport.DomainUnload(object source, EventArgs arguments)
	{
		if (<Module>.?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA != 0 && Interlocked.Exchange(ref <Module>.?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA, 1) == 0)
		{
			<Module>._app_exit_callback();
		}
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002678 File Offset: 0x00001A78
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[DebuggerStepThrough]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.Cleanup(LanguageSupport* A_0, Exception innerException)
	{
		try
		{
			<Module>.<CrtImplementationDetails>.LanguageSupport.UninitializeAppDomain();
		}
		catch (Exception ex)
		{
			<Module>.<CrtImplementationDetails>.ThrowNestedModuleLoadException(innerException, ex);
		}
		catch (object obj)
		{
			<Module>.<CrtImplementationDetails>.ThrowNestedModuleLoadException(innerException, null);
		}
	}

	// Token: 0x0600001F RID: 31 RVA: 0x000029AC File Offset: 0x00001DAC
	[DebuggerStepThrough]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.Initialize(LanguageSupport* A_0)
	{
		try
		{
			<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load.\n");
			<Module>.<CrtImplementationDetails>.LanguageSupport._Initialize(A_0);
		}
		catch (Exception ex)
		{
			<Module>.<CrtImplementationDetails>.LanguageSupport.Cleanup(A_0, ex);
			<Module>.<CrtImplementationDetails>.ThrowModuleLoadException(<Module>.gcroot<System::String\u0020^>..P$AAVString@System@@(A_0), ex);
		}
		catch (object obj)
		{
			<Module>.<CrtImplementationDetails>.LanguageSupport.Cleanup(A_0, null);
			<Module>.<CrtImplementationDetails>.ThrowModuleLoadException(<Module>.gcroot<System::String\u0020^>..P$AAVString@System@@(A_0), null);
		}
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002A30 File Offset: 0x00001E30
	[DebuggerStepThrough]
	static unsafe <Module>()
	{
		LanguageSupport languageSupport;
		<Module>.<CrtImplementationDetails>.LanguageSupport.{ctor}(ref languageSupport);
		try
		{
			<Module>.<CrtImplementationDetails>.LanguageSupport.Initialize(ref languageSupport);
		}
		catch
		{
			<Module>.___CxxCallUnwindDtor(ldftn(<CrtImplementationDetails>.LanguageSupport.{dtor}), (void*)(&languageSupport));
			throw;
		}
		<Module>.gcroot<System::String\u0020^>.{dtor}(ref languageSupport);
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002898 File Offset: 0x00001C98
	internal unsafe static LanguageSupport* <CrtImplementationDetails>.LanguageSupport.{ctor}(LanguageSupport* A_0)
	{
		<Module>.gcroot<System::String\u0020^>.{ctor}(A_0);
		return A_0;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x000028B4 File Offset: 0x00001CB4
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.{dtor}(LanguageSupport* A_0)
	{
		<Module>.gcroot<System::String\u0020^>.{dtor}(A_0);
	}

	// Token: 0x06000023 RID: 35 RVA: 0x000026D4 File Offset: 0x00001AD4
	[DebuggerStepThrough]
	internal unsafe static gcroot<System::String\u0020^>* {ctor}(gcroot<System::String\u0020^>* A_0)
	{
		*A_0 = ((IntPtr)GCHandle.Alloc(null)).ToPointer();
		return A_0;
	}

	// Token: 0x06000024 RID: 36 RVA: 0x000026F8 File Offset: 0x00001AF8
	[DebuggerStepThrough]
	internal unsafe static void {dtor}(gcroot<System::String\u0020^>* A_0)
	{
		IntPtr value = new IntPtr(*A_0);
		((GCHandle)value).Free();
		*A_0 = 0;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002720 File Offset: 0x00001B20
	[DebuggerStepThrough]
	internal unsafe static gcroot<System::String\u0020^>* =(gcroot<System::String\u0020^>* A_0, string t)
	{
		IntPtr value = new IntPtr(*A_0);
		((GCHandle)value).Target = t;
		return A_0;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002748 File Offset: 0x00001B48
	internal unsafe static string P$AAVString@System@@(gcroot<System::String\u0020^>* A_0)
	{
		IntPtr value = new IntPtr(*A_0);
		return ((GCHandle)value).Target;
	}

	// Token: 0x06000027 RID: 39 RVA: 0x0000C6C4 File Offset: 0x0000BAC4
	internal static void ??__E?A0x11773762@SA_Yes@@YMXXZ()
	{
		<Module>.?A0x11773762.SA_Yes = (YesNoMaybe)268370176;
	}

	// Token: 0x06000028 RID: 40 RVA: 0x0000C6DC File Offset: 0x0000BADC
	internal static void ??__E?A0x11773762@SA_No@@YMXXZ()
	{
		<Module>.?A0x11773762.SA_No = (YesNoMaybe)268369921;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x0000C6F4 File Offset: 0x0000BAF4
	internal static void ??__E?A0x11773762@SA_Maybe@@YMXXZ()
	{
		<Module>.?A0x11773762.SA_Maybe = (YesNoMaybe)268369936;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x0000C70C File Offset: 0x0000BB0C
	internal static void ??__E?A0x11773762@SA_NoAccess@@YMXXZ()
	{
		<Module>.?A0x11773762.SA_NoAccess = (AccessType)0;
	}

	// Token: 0x0600002B RID: 43 RVA: 0x0000C720 File Offset: 0x0000BB20
	internal static void ??__E?A0x11773762@SA_Read@@YMXXZ()
	{
		<Module>.?A0x11773762.SA_Read = (AccessType)1;
	}

	// Token: 0x0600002C RID: 44 RVA: 0x0000C734 File Offset: 0x0000BB34
	internal static void ??__E?A0x11773762@SA_Write@@YMXXZ()
	{
		<Module>.?A0x11773762.SA_Write = (AccessType)2;
	}

	// Token: 0x0600002D RID: 45 RVA: 0x0000C748 File Offset: 0x0000BB48
	internal static void ??__E?A0x11773762@SA_ReadWrite@@YMXXZ()
	{
		<Module>.?A0x11773762.SA_ReadWrite = (AccessType)3;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002E98 File Offset: 0x00002298
	internal static int _atexit_m(method _Function)
	{
		return <Module>._atexit_m_appdomain(_Function);
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002EAC File Offset: 0x000022AC
	internal static int atexit(method _Function)
	{
		return <Module>._atexit_m_appdomain(_Function);
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002A80 File Offset: 0x00001E80
	[DebuggerStepThrough]
	internal static ValueType <CrtImplementationDetails>.AtExitLock._handle()
	{
		if (<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA != null)
		{
			IntPtr value = new IntPtr(<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA);
			return GCHandle.FromIntPtr(value);
		}
		return null;
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002EC0 File Offset: 0x000022C0
	[DebuggerStepThrough]
	internal static void <CrtImplementationDetails>.AtExitLock._lock_Construct(object value)
	{
		<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA = null;
		<Module>.<CrtImplementationDetails>.AtExitLock._lock_Set(value);
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002AB0 File Offset: 0x00001EB0
	[DebuggerStepThrough]
	internal static void <CrtImplementationDetails>.AtExitLock._lock_Set(object value)
	{
		ValueType valueType = <Module>.<CrtImplementationDetails>.AtExitLock._handle();
		if (valueType == null)
		{
			valueType = GCHandle.Alloc(value);
			<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA = GCHandle.ToIntPtr((GCHandle)valueType).ToPointer();
		}
		else
		{
			((GCHandle)valueType).Target = value;
		}
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002B00 File Offset: 0x00001F00
	[DebuggerStepThrough]
	internal static object <CrtImplementationDetails>.AtExitLock._lock_Get()
	{
		ValueType valueType = <Module>.<CrtImplementationDetails>.AtExitLock._handle();
		if (valueType != null)
		{
			return ((GCHandle)valueType).Target;
		}
		return null;
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002B24 File Offset: 0x00001F24
	[DebuggerStepThrough]
	internal static void <CrtImplementationDetails>.AtExitLock._lock_Destruct()
	{
		ValueType valueType = <Module>.<CrtImplementationDetails>.AtExitLock._handle();
		if (valueType != null)
		{
			((GCHandle)valueType).Free();
			<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA = null;
		}
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002B4C File Offset: 0x00001F4C
	[DebuggerStepThrough]
	[return: MarshalAs(UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.AtExitLock.IsInitialized()
	{
		return ((<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get() != null) ? 1 : 0) != 0;
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002EDC File Offset: 0x000022DC
	[DebuggerStepThrough]
	internal static void <CrtImplementationDetails>.AtExitLock.AddRef()
	{
		if (!<Module>.<CrtImplementationDetails>.AtExitLock.IsInitialized())
		{
			object value = new object();
			<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA = null;
			<Module>.<CrtImplementationDetails>.AtExitLock._lock_Set(value);
			<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA = 0;
		}
		<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA++;
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002B68 File Offset: 0x00001F68
	[DebuggerStepThrough]
	internal static void <CrtImplementationDetails>.AtExitLock.RemoveRef()
	{
		<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA--;
		if (<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA == 0)
		{
			<Module>.<CrtImplementationDetails>.AtExitLock._lock_Destruct();
		}
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002B90 File Offset: 0x00001F90
	[DebuggerStepThrough]
	internal static void <CrtImplementationDetails>.AtExitLock.Enter()
	{
		Monitor.Enter(<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get());
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002BA8 File Offset: 0x00001FA8
	[DebuggerStepThrough]
	internal static void <CrtImplementationDetails>.AtExitLock.Exit()
	{
		Monitor.Exit(<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get());
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002BC0 File Offset: 0x00001FC0
	[DebuggerStepThrough]
	[return: MarshalAs(UnmanagedType.U1)]
	internal static bool __global_lock()
	{
		bool result = false;
		if (<Module>.<CrtImplementationDetails>.AtExitLock.IsInitialized())
		{
			Monitor.Enter(<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get());
			result = true;
		}
		return result;
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002BE4 File Offset: 0x00001FE4
	[DebuggerStepThrough]
	[return: MarshalAs(UnmanagedType.U1)]
	internal static bool __global_unlock()
	{
		bool result = false;
		if (<Module>.<CrtImplementationDetails>.AtExitLock.IsInitialized())
		{
			Monitor.Exit(<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get());
			result = true;
		}
		return result;
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002F14 File Offset: 0x00002314
	[DebuggerStepThrough]
	[return: MarshalAs(UnmanagedType.U1)]
	internal static bool __alloc_global_lock()
	{
		<Module>.<CrtImplementationDetails>.AtExitLock.AddRef();
		return <Module>.<CrtImplementationDetails>.AtExitLock.IsInitialized();
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00002C08 File Offset: 0x00002008
	[DebuggerStepThrough]
	internal static void __dealloc_global_lock()
	{
		<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA--;
		if (<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA == 0)
		{
			<Module>.<CrtImplementationDetails>.AtExitLock._lock_Destruct();
		}
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00002C30 File Offset: 0x00002030
	internal unsafe static int _atexit_helper(method func, uint* __pexit_list_size, method** __ponexitend_e, method** __ponexitbegin_e)
	{
		method system.Void_u0020() = 0;
		if (func == null)
		{
			return -1;
		}
		if (<Module>.?A0x11773762.__global_lock())
		{
			try
			{
				method* ptr = <Module>._decode_pointer(*(int*)__ponexitbegin_e);
				method* ptr2 = <Module>._decode_pointer(*(int*)__ponexitend_e);
				method* ptr3 = ptr2 - ptr;
				if (*__pexit_list_size - 1u < ptr3 >> 2)
				{
					try
					{
						uint num = *__pexit_list_size * 4u;
						uint num2;
						if (num < 2048u)
						{
							num2 = num;
						}
						else
						{
							num2 = 2048u;
						}
						IntPtr cb = new IntPtr((int)(num + num2));
						IntPtr pv = new IntPtr((void*)ptr);
						IntPtr intPtr = Marshal.ReAllocHGlobal(pv, cb);
						ptr2 = (method*)((byte*)intPtr.ToPointer() + ptr3);
						ptr = (method*)intPtr.ToPointer();
						uint num3 = *__pexit_list_size;
						uint num4;
						if (512u < num3)
						{
							num4 = 512u;
						}
						else
						{
							num4 = num3;
						}
						*__pexit_list_size = num3 + num4;
					}
					catch (OutOfMemoryException)
					{
						IntPtr cb2 = new IntPtr((int)(*__pexit_list_size * 4u + 8u));
						IntPtr pv2 = new IntPtr((void*)ptr);
						IntPtr intPtr2 = Marshal.ReAllocHGlobal(pv2, cb2);
						ptr2 = (intPtr2.ToPointer() - ptr) / (IntPtr)sizeof(method) + ptr2;
						ptr = (method*)intPtr2.ToPointer();
						*__pexit_list_size += 4u;
					}
				}
				*(int*)ptr2 = func;
				ptr2 += 4 / sizeof(method);
				system.Void_u0020() = func;
				*(int*)__ponexitbegin_e = <Module>._encode_pointer((void*)ptr);
				*(int*)__ponexitend_e = <Module>._encode_pointer((void*)ptr2);
			}
			catch (OutOfMemoryException)
			{
			}
			finally
			{
				<Module>.?A0x11773762.__global_unlock();
			}
			if (system.Void_u0020() != null)
			{
				return 0;
			}
		}
		return -1;
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00002F2C File Offset: 0x0000232C
	[DebuggerStepThrough]
	internal static int _initatexit_app_domain()
	{
		if (<Module>.?A0x11773762.__alloc_global_lock())
		{
			<Module>.__onexitbegin_app_domain = <Module>._encode_pointer(Marshal.AllocHGlobal(128).ToPointer());
			<Module>.__onexitend_app_domain = <Module>.__onexitbegin_app_domain;
			<Module>.__exit_list_size_app_domain = 32u;
			<Module>._atexit_m_appdomain(ldftn(__clean_type_info_names));
		}
		return 1;
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00002D9C File Offset: 0x0000219C
	internal unsafe static void _app_exit_callback()
	{
		if (<Module>.__exit_list_size_app_domain != 0u)
		{
			method* ptr = <Module>._decode_pointer((void*)<Module>.__onexitbegin_app_domain);
			method* ptr2 = <Module>._decode_pointer((void*)<Module>.__onexitend_app_domain);
			try
			{
				if (ptr != -1 && ptr != null && ptr2 != null)
				{
					method* ptr3 = ptr;
					method* ptr4 = ptr2;
					for (;;)
					{
						do
						{
							ptr2 -= 4 / sizeof(method);
						}
						while (ptr2 >= ptr && *(int*)ptr2 == <Module>._encoded_null());
						if (ptr2 < ptr)
						{
							break;
						}
						method system.Void_u0020() = <Module>._decode_pointer(*(int*)ptr2);
						*(int*)ptr2 = <Module>._encoded_null();
						calli(System.Void(), system.Void_u0020());
						method* ptr5 = <Module>._decode_pointer((void*)<Module>.__onexitbegin_app_domain);
						method* ptr6 = <Module>._decode_pointer((void*)<Module>.__onexitend_app_domain);
						if (ptr3 != ptr5 || ptr4 != ptr6)
						{
							ptr3 = ptr5;
							ptr = ptr5;
							ptr4 = ptr6;
							ptr2 = ptr6;
						}
					}
				}
			}
			finally
			{
				IntPtr hglobal = new IntPtr((void*)ptr);
				Marshal.FreeHGlobal(hglobal);
				<Module>.?A0x11773762.__dealloc_global_lock();
			}
		}
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002F7C File Offset: 0x0000237C
	internal static method _onexit_m_appdomain(method _Function)
	{
		return (<Module>._atexit_m_appdomain(_Function) == -1) ? 0 : _Function;
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00002E70 File Offset: 0x00002270
	[DebuggerStepThrough]
	internal unsafe static int _atexit_m_appdomain(method func)
	{
		return <Module>._atexit_helper(<Module>._encode_pointer(func), &<Module>.__exit_list_size_app_domain, &<Module>.__onexitend_app_domain, &<Module>.__onexitbegin_app_domain);
	}

	// Token: 0x06000043 RID: 67 RVA: 0x0000C75C File Offset: 0x0000BB5C
	internal static void ??__E?A0x53c7229f@SA_Yes@@YMXXZ()
	{
		<Module>.?A0x53c7229f.SA_Yes = (YesNoMaybe)268370176;
	}

	// Token: 0x06000044 RID: 68 RVA: 0x0000C774 File Offset: 0x0000BB74
	internal static void ??__E?A0x53c7229f@SA_No@@YMXXZ()
	{
		<Module>.?A0x53c7229f.SA_No = (YesNoMaybe)268369921;
	}

	// Token: 0x06000045 RID: 69 RVA: 0x0000C78C File Offset: 0x0000BB8C
	internal static void ??__E?A0x53c7229f@SA_Maybe@@YMXXZ()
	{
		<Module>.?A0x53c7229f.SA_Maybe = (YesNoMaybe)268369936;
	}

	// Token: 0x06000046 RID: 70 RVA: 0x0000C7A4 File Offset: 0x0000BBA4
	internal static void ??__E?A0x53c7229f@SA_NoAccess@@YMXXZ()
	{
		<Module>.?A0x53c7229f.SA_NoAccess = (AccessType)0;
	}

	// Token: 0x06000047 RID: 71 RVA: 0x0000C7B8 File Offset: 0x0000BBB8
	internal static void ??__E?A0x53c7229f@SA_Read@@YMXXZ()
	{
		<Module>.?A0x53c7229f.SA_Read = (AccessType)1;
	}

	// Token: 0x06000048 RID: 72 RVA: 0x0000C7CC File Offset: 0x0000BBCC
	internal static void ??__E?A0x53c7229f@SA_Write@@YMXXZ()
	{
		<Module>.?A0x53c7229f.SA_Write = (AccessType)2;
	}

	// Token: 0x06000049 RID: 73 RVA: 0x0000C7E0 File Offset: 0x0000BBE0
	internal static void ??__E?A0x53c7229f@SA_ReadWrite@@YMXXZ()
	{
		<Module>.?A0x53c7229f.SA_ReadWrite = (AccessType)3;
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00002F98 File Offset: 0x00002398
	[DebuggerStepThrough]
	internal static ModuleHandle <CrtImplementationDetails>.ThisModule.Handle()
	{
		return typeof(ThisModule).Module.ModuleHandle;
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00002FE8 File Offset: 0x000023E8
	[DebuggerStepThrough]
	internal unsafe static void _initterm_m(method* pfbegin, method* pfend)
	{
		if (pfbegin < pfend)
		{
			do
			{
				uint num = (uint)(*(int*)pfbegin);
				if (num != 0u)
				{
					object obj = calli(System.Void modopt(System.Runtime.CompilerServices.IsConst)*(), <Module>.<CrtImplementationDetails>.ThisModule.ResolveMethod<void\u0020const\u0020*\u0020__clrcall(void)>(num));
				}
				pfbegin += 4 / sizeof(method);
			}
			while (pfbegin < pfend);
		}
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00002FBC File Offset: 0x000023BC
	[DebuggerStepThrough]
	internal static method <CrtImplementationDetails>.ThisModule.ResolveMethod<void\u0020const\u0020*\u0020__clrcall(void)>(method methodToken)
	{
		return <Module>.<CrtImplementationDetails>.ThisModule.Handle().ResolveMethodHandle(methodToken).GetFunctionPointer().ToPointer();
	}

	// Token: 0x0600004D RID: 77 RVA: 0x0000C7F4 File Offset: 0x0000BBF4
	internal static void ??__E?A0x23171040@SA_Yes@@YMXXZ()
	{
		<Module>.?A0x23171040.SA_Yes = (YesNoMaybe)268370176;
	}

	// Token: 0x0600004E RID: 78 RVA: 0x0000C80C File Offset: 0x0000BC0C
	internal static void ??__E?A0x23171040@SA_No@@YMXXZ()
	{
		<Module>.?A0x23171040.SA_No = (YesNoMaybe)268369921;
	}

	// Token: 0x0600004F RID: 79 RVA: 0x0000C824 File Offset: 0x0000BC24
	internal static void ??__E?A0x23171040@SA_Maybe@@YMXXZ()
	{
		<Module>.?A0x23171040.SA_Maybe = (YesNoMaybe)268369936;
	}

	// Token: 0x06000050 RID: 80 RVA: 0x0000C83C File Offset: 0x0000BC3C
	internal static void ??__E?A0x23171040@SA_NoAccess@@YMXXZ()
	{
		<Module>.?A0x23171040.SA_NoAccess = (AccessType)0;
	}

	// Token: 0x06000051 RID: 81 RVA: 0x0000C850 File Offset: 0x0000BC50
	internal static void ??__E?A0x23171040@SA_Read@@YMXXZ()
	{
		<Module>.?A0x23171040.SA_Read = (AccessType)1;
	}

	// Token: 0x06000052 RID: 82 RVA: 0x0000C864 File Offset: 0x0000BC64
	internal static void ??__E?A0x23171040@SA_Write@@YMXXZ()
	{
		<Module>.?A0x23171040.SA_Write = (AccessType)2;
	}

	// Token: 0x06000053 RID: 83 RVA: 0x0000C878 File Offset: 0x0000BC78
	internal static void ??__E?A0x23171040@SA_ReadWrite@@YMXXZ()
	{
		<Module>.?A0x23171040.SA_ReadWrite = (AccessType)3;
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00003014 File Offset: 0x00002414
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static void __DestructExceptionObject_m(EHExceptionRecord* pExcept, byte fThrowNotAllowed)
	{
		if (pExcept != null)
		{
			uint num = (uint)(*(*(int*)(pExcept + 28 / sizeof(EHExceptionRecord)) + 4));
			if (num != 0u)
			{
				int num2;
				try
				{
					method system.Void_u0020(System.Void*) = num;
					calli(System.Void(System.Void*), *(int*)(pExcept + 24 / sizeof(EHExceptionRecord)), system.Void_u0020(System.Void*));
				}
				catch when (delegate
				{
					// Failed to create a 'catch-when' expression
					num2 = ((fThrowNotAllowed != 0) ? 1 : 0);
					endfilter(num2 != 0);
				})
				{
					<Module>.terminate();
				}
			}
		}
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00003610 File Offset: 0x00002A10
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static int ___CxxExceptionFilter(void* ppExcept, void* pType, int adjectives, void* pBuildObj)
	{
		if (ppExcept == null)
		{
			return 0;
		}
		EHExceptionRecord* ptr = *(int*)ppExcept;
		if (pType == null || *(sbyte*)((byte*)pType + 8) == 0)
		{
			uint num = (uint)(*(int*)ptr);
			if (num == 3762507597u || (adjectives & 64) == 0)
			{
				if (num == 3765269347u && *(int*)(ptr + 16 / sizeof(EHExceptionRecord)) == 3 && (*(int*)(ptr + 20 / sizeof(EHExceptionRecord)) == 26820608 || *(int*)(ptr + 28 / sizeof(EHExceptionRecord)) == 0) && *(int*)(ptr + 28 / sizeof(EHExceptionRecord)) == 0 && *(<Module>._getptd() + 136) == 0)
				{
					return 0;
				}
				(*(<Module>._getptd() + 144))++;
				return 1;
			}
		}
		if (*(int*)ptr == -529697949 && *(int*)(ptr + 16 / sizeof(EHExceptionRecord)) == 3 && (*(int*)(ptr + 20 / sizeof(EHExceptionRecord)) == 26820608 || *(int*)(ptr + 28 / sizeof(EHExceptionRecord)) == 0))
		{
			if (*(int*)(ptr + 28 / sizeof(EHExceptionRecord)) == 0)
			{
				if (*(<Module>._getptd() + 136) == 0)
				{
					return 0;
				}
				ptr = *(<Module>._getptd() + 136);
			}
			_s_HandlerType s_HandlerType;
			*(ref s_HandlerType + 4) = pType;
			s_HandlerType = (adjectives | int.MinValue);
			int num2 = *(*(int*)(ptr + 28 / sizeof(EHExceptionRecord)) + 12);
			_s_CatchableType** ptr2 = num2 + 4;
			int num3 = *num2;
			if (num3 > 0)
			{
				do
				{
					_s_CatchableType* ptr3 = *(int*)ptr2;
					if (<Module>.?A0x23171040.TypeMatch<struct\u0020_s_HandlerType,struct\u0020_s_CatchableType\u0020const\u0020,struct\u0020_s_ThrowInfo\u0020const\u0020>(&s_HandlerType, ptr3, *(int*)(ptr + 28 / sizeof(EHExceptionRecord))) != 0)
					{
						goto IL_C3;
					}
					num3--;
					ptr2 += 4 / sizeof(_s_CatchableType*);
				}
				while (num3 > 0);
				return 0;
				IL_C3:
				(*(<Module>._getptd() + 144))++;
				if (pBuildObj != null)
				{
					_s_CatchableType* ptr3;
					<Module>.?A0x23171040.BuildCatchObject<struct\u0020_s_HandlerType,struct\u0020_s_CatchableType\u0020const\u0020>(ptr, pBuildObj, &s_HandlerType, ptr3);
				}
				return 1;
			}
		}
		return 0;
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00003074 File Offset: 0x00002474
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static int ___CxxRegisterExceptionObject(void* ppExcept, void* pStorage)
	{
		if (ppExcept != null)
		{
			uint num = (uint)(*(int*)ppExcept);
			if (num != 0u)
			{
				EHExceptionRecord* ptr = num;
				if (*(int*)ptr == -529697949 && *(int*)(ptr + 16 / sizeof(EHExceptionRecord)) == 3 && (*(int*)(ptr + 20 / sizeof(EHExceptionRecord)) == 26820608 || *(int*)(ptr + 28 / sizeof(EHExceptionRecord)) == 0) && *(int*)(ptr + 28 / sizeof(EHExceptionRecord)) == 0)
				{
					ptr = *(<Module>._getptd() + 136);
				}
				<Module>._CreateFrameInfo((FrameInfo*)pStorage, *(int*)(ptr + 24 / sizeof(EHExceptionRecord)));
				*(int*)((byte*)pStorage + 8) = *(<Module>._getptd() + 136);
				*(int*)((byte*)((byte*)pStorage + 8) + 4) = *(<Module>._getptd() + 140);
				*(<Module>._getptd() + 136) = ptr;
				goto IL_92;
			}
		}
		*(int*)((byte*)pStorage + 8) = -1;
		*(int*)((byte*)((byte*)pStorage + 8) + 4) = -1;
		IL_92:
		*(<Module>._getptd() + 144) += -1;
		if (*(<Module>._getptd() + 144) < 0)
		{
			*(<Module>._getptd() + 144) = 0;
		}
		return 1;
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00003140 File Offset: 0x00002540
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static int ___CxxDetectRethrow(void* ppExcept)
	{
		if (ppExcept == null)
		{
			return 0;
		}
		EHExceptionRecord* ptr = *(int*)ppExcept;
		if (*(int*)ptr == -529697949 && *(int*)(ptr + 16 / sizeof(EHExceptionRecord)) == 3 && (*(int*)(ptr + 20 / sizeof(EHExceptionRecord)) == 26820608 || *(int*)(ptr + 28 / sizeof(EHExceptionRecord)) == 0) && *(int*)(ptr + 28 / sizeof(EHExceptionRecord)) == 0)
		{
			(*(<Module>._getptd() + 144))++;
			return 1;
		}
		return 0;
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00003194 File Offset: 0x00002594
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static void ___CxxUnregisterExceptionObject(void* pStorage, int rethrow)
	{
		EHExceptionRecord** ptr = (EHExceptionRecord**)((byte*)pStorage + 8);
		_CONTEXT** ptr2 = (_CONTEXT**)(ptr + 4 / sizeof(EHExceptionRecord*));
		if (*(int*)ptr != -1)
		{
			<Module>._FindAndUnlinkFrame((FrameInfo*)pStorage);
			if (rethrow == 0 && *(*(<Module>._getptd() + 136)) == -529697949 && *(*(<Module>._getptd() + 136) + 16) == 3 && (*(*(<Module>._getptd() + 136) + 20) == 26820608 || *(*(<Module>._getptd() + 136) + 28) == 0) && <Module>._IsExceptionObjectToBeDestroyed(*(*(<Module>._getptd() + 136) + 24)) != null)
			{
				<Module>.?A0x23171040.__DestructExceptionObject_m(*(<Module>._getptd() + 136), 1);
			}
			if (*(*(<Module>._getptd() + 136)) == -529697949 && *(*(<Module>._getptd() + 136) + 16) == 3 && (*(*(<Module>._getptd() + 136) + 20) == 26820608 || *(*(<Module>._getptd() + 136) + 28) == 0) && rethrow != 0)
			{
				*(<Module>._getptd() + 144) += -1;
			}
			*(<Module>._getptd() + 136) = *(int*)ptr;
			*(<Module>._getptd() + 140) = *(int*)ptr2;
		}
	}

	// Token: 0x06000059 RID: 89 RVA: 0x000032B8 File Offset: 0x000026B8
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static int ___CxxQueryExceptionSize()
	{
		return 16;
	}

	// Token: 0x0600005A RID: 90 RVA: 0x000032C8 File Offset: 0x000026C8
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static void ___CxxCallUnwindDtor(method pDtor, void* pThis)
	{
		try
		{
			calli(System.Void(System.Void*), pThis, pDtor);
		}
		catch when (endfilter(<Module>.__FrameUnwindFilter(Marshal.GetExceptionPointers()) != null))
		{
		}
	}

	// Token: 0x0600005B RID: 91 RVA: 0x0000330C File Offset: 0x0000270C
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static void ___CxxCallUnwindDelDtor(method pDtor, void* pThis)
	{
		try
		{
			calli(System.Void(System.Void*), pThis, pDtor);
		}
		catch when (endfilter(<Module>.__FrameUnwindFilter(Marshal.GetExceptionPointers()) != null))
		{
		}
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00003350 File Offset: 0x00002750
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static void ___CxxCallUnwindVecDtor(method pVecDtor, void* ptr, uint size, int count, method pDtor)
	{
		try
		{
			calli(System.Void(System.Void*,System.UInt32,System.Int32,System.Void (System.Void*)), ptr, size, count, pDtor, pVecDtor);
		}
		catch when (endfilter(<Module>.__FrameUnwindFilter(Marshal.GetExceptionPointers()) != null))
		{
		}
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00003398 File Offset: 0x00002798
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static int TypeMatch<struct\u0020_s_HandlerType,struct\u0020_s_CatchableType\u0020const\u0020,struct\u0020_s_ThrowInfo\u0020const\u0020>(_s_HandlerType* pCatch, _s_CatchableType* pCatchable, _s_ThrowInfo* pThrow)
	{
		uint num = (uint)(*(int*)(pCatch + 4 / sizeof(_s_HandlerType)));
		if (num != 0u)
		{
			int num2 = (int)(num + 8u);
			if (*num2 != 0)
			{
				uint num3 = (uint)(*(int*)(pCatchable + 4 / sizeof(_s_CatchableType)));
				if (num != num3 && <Module>.strcmp(num2, num3 + 8u) != null)
				{
					return 0;
				}
				if ((*(int*)pCatchable & 2) == 0 || (*(int*)pCatch & 8) != 0)
				{
					uint num4 = (uint)(*(int*)pThrow);
					if (((num4 & 1u) == 0u || (*(int*)pCatch & 1) != 0) && ((num4 & 2u) == 0u || (*(int*)pCatch & 2) != 0))
					{
						return 1;
					}
				}
				return 0;
			}
		}
		return 1;
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00003580 File Offset: 0x00002980
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static void BuildCatchObject<struct\u0020_s_HandlerType,struct\u0020_s_CatchableType\u0020const\u0020>(EHExceptionRecord* pExcept, void* pRN, _s_HandlerType* pCatch, _s_CatchableType* pConv)
	{
		if ((*(int*)pCatch & -2147483648) == 0)
		{
			<Module>._inconsistency();
		}
		try
		{
			int num = <Module>.?A0x23171040.BuildCatchObjectHelper<struct\u0020_s_HandlerType,struct\u0020_s_CatchableType\u0020const\u0020>(pExcept, pRN, pCatch, pConv);
			if (num != 1)
			{
				if (num == 2)
				{
					method system.Void_u0020(System.Void*,System.Void*,System.Int32) = *(int*)(pConv + 24 / sizeof(_s_CatchableType));
					calli(System.Void(System.Void*,System.Void*,System.Int32), pRN, <Module>.__AdjustPointer(*(int*)(pExcept + 24 / sizeof(EHExceptionRecord)), pConv + 8 / sizeof(_s_CatchableType)), 1, system.Void_u0020(System.Void*,System.Void*,System.Int32));
				}
			}
			else
			{
				method system.Void_u0020(System.Void*,System.Void*) = *(int*)(pConv + 24 / sizeof(_s_CatchableType));
				calli(System.Void(System.Void*,System.Void*), pRN, <Module>.__AdjustPointer(*(int*)(pExcept + 24 / sizeof(EHExceptionRecord)), pConv + 8 / sizeof(_s_CatchableType)), system.Void_u0020(System.Void*,System.Void*));
			}
		}
		catch when (endfilter(true))
		{
			<Module>.terminate();
		}
	}

	// Token: 0x0600005F RID: 95 RVA: 0x000033FC File Offset: 0x000027FC
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static int BuildCatchObjectHelper<struct\u0020_s_HandlerType,struct\u0020_s_CatchableType\u0020const\u0020>(EHExceptionRecord* pExcept, void* pRN, _s_HandlerType* pCatch, _s_CatchableType* pConv)
	{
		int result = 0;
		uint num = (uint)(*(int*)(pCatch + 4 / sizeof(_s_HandlerType)));
		if (num != 0u && *(num + 8u) != 0 && (*(int*)(pCatch + 8 / sizeof(_s_HandlerType)) != 0 || (*(int*)pCatch & -2147483648) != 0))
		{
			if ((*(int*)pCatch & -2147483648) == 0)
			{
				<Module>._inconsistency();
			}
			try
			{
				if ((*(int*)pCatch & 8) != 0)
				{
					if (<Module>._ValidateRead(*(int*)(pExcept + 24 / sizeof(EHExceptionRecord)), 1u) != null && <Module>._ValidateWrite(pRN, 1u) != null)
					{
						int num2 = *(int*)(pExcept + 24 / sizeof(EHExceptionRecord));
						*(int*)pRN = num2;
						*(int*)pRN = <Module>.__AdjustPointer(num2, pConv + 8 / sizeof(_s_CatchableType));
					}
					else
					{
						<Module>._inconsistency();
					}
				}
				else if ((*(int*)pConv & 1) != 0)
				{
					if (<Module>._ValidateRead(*(int*)(pExcept + 24 / sizeof(EHExceptionRecord)), 1u) != null && <Module>._ValidateWrite(pRN, 1u) != null)
					{
						<Module>.memmove(pRN, *(int*)(pExcept + 24 / sizeof(EHExceptionRecord)), (uint)(*(int*)(pConv + 20 / sizeof(_s_CatchableType))));
						if (*(int*)(pConv + 20 / sizeof(_s_CatchableType)) == 4)
						{
							uint num3 = (uint)(*(int*)pRN);
							if (num3 != 0u)
							{
								*(int*)pRN = <Module>.__AdjustPointer(num3, pConv + 8 / sizeof(_s_CatchableType));
							}
						}
					}
					else
					{
						<Module>._inconsistency();
					}
				}
				else if (*(int*)(pConv + 24 / sizeof(_s_CatchableType)) == 0)
				{
					if (<Module>._ValidateRead(*(int*)(pExcept + 24 / sizeof(EHExceptionRecord)), 1u) != null && <Module>._ValidateWrite(pRN, 1u) != null)
					{
						<Module>.memmove(pRN, <Module>.__AdjustPointer(*(int*)(pExcept + 24 / sizeof(EHExceptionRecord)), pConv + 8 / sizeof(_s_CatchableType)), (uint)(*(int*)(pConv + 20 / sizeof(_s_CatchableType))));
					}
					else
					{
						<Module>._inconsistency();
					}
				}
				else if (<Module>._ValidateRead(*(int*)(pExcept + 24 / sizeof(EHExceptionRecord)), 1u) != null && <Module>._ValidateWrite(pRN, 1u) != null && <Module>._ValidateExecute(*(int*)(pConv + 24 / sizeof(_s_CatchableType))) != null)
				{
					result = (((*(int*)pConv & 4) != 0) ? 2 : 1);
				}
				else
				{
					<Module>._inconsistency();
				}
			}
			catch when (endfilter(true))
			{
				<Module>.terminate();
			}
			return result;
		}
		return 0;
	}

	// Token: 0x06000060 RID: 96 RVA: 0x0000C88C File Offset: 0x0000BC8C
	internal static void ??__E?A0x3133a0bf@SA_Yes@@YMXXZ()
	{
		<Module>.?A0x3133a0bf.SA_Yes = (YesNoMaybe)268370176;
	}

	// Token: 0x06000061 RID: 97 RVA: 0x0000C8A4 File Offset: 0x0000BCA4
	internal static void ??__E?A0x3133a0bf@SA_No@@YMXXZ()
	{
		<Module>.?A0x3133a0bf.SA_No = (YesNoMaybe)268369921;
	}

	// Token: 0x06000062 RID: 98 RVA: 0x0000C8BC File Offset: 0x0000BCBC
	internal static void ??__E?A0x3133a0bf@SA_Maybe@@YMXXZ()
	{
		<Module>.?A0x3133a0bf.SA_Maybe = (YesNoMaybe)268369936;
	}

	// Token: 0x06000063 RID: 99 RVA: 0x0000C8D4 File Offset: 0x0000BCD4
	internal static void ??__E?A0x3133a0bf@SA_NoAccess@@YMXXZ()
	{
		<Module>.?A0x3133a0bf.SA_NoAccess = (AccessType)0;
	}

	// Token: 0x06000064 RID: 100 RVA: 0x0000C8E8 File Offset: 0x0000BCE8
	internal static void ??__E?A0x3133a0bf@SA_Read@@YMXXZ()
	{
		<Module>.?A0x3133a0bf.SA_Read = (AccessType)1;
	}

	// Token: 0x06000065 RID: 101 RVA: 0x0000C8FC File Offset: 0x0000BCFC
	internal static void ??__E?A0x3133a0bf@SA_Write@@YMXXZ()
	{
		<Module>.?A0x3133a0bf.SA_Write = (AccessType)2;
	}

	// Token: 0x06000066 RID: 102 RVA: 0x0000C910 File Offset: 0x0000BD10
	internal static void ??__E?A0x3133a0bf@SA_ReadWrite@@YMXXZ()
	{
		<Module>.?A0x3133a0bf.SA_ReadWrite = (AccessType)3;
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00003750 File Offset: 0x00002B50
	internal unsafe static void _invoke_watson_if_error(int _ExpressionError, char* _Expression, char* _Function, char* _File, uint _Line, uint _Reserved)
	{
		if (_ExpressionError != 0)
		{
			<Module>._invoke_watson(_Expression, _Function, _File, _Line, _Reserved);
		}
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00003A50 File Offset: 0x00002E50
	internal unsafe static sbyte* name(type_info* A_0, __type_info_node* __ptype_info_node)
	{
		return <Module>.type_info._Name_base(A_0, __ptype_info_node);
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00003A64 File Offset: 0x00002E64
	internal unsafe static void {dtor}(type_info* A_0)
	{
		*A_0 = ref <Module>.??_7type_info@@6B@ + 4;
		<Module>.type_info._Type_info_dtor(A_0);
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00003A80 File Offset: 0x00002E80
	internal unsafe static void* __vecDelDtor(type_info* A_0, uint A_1)
	{
		if ((A_1 & 2u) != 0u)
		{
			type_info* ptr = A_0 - 4;
			<Module>.__ehvec_dtor(A_0, 12u, *ptr, ldftn(type_info.{dtor}));
			if ((A_1 & 1u) != 0u)
			{
				<Module>.delete(ptr);
			}
			return ptr;
		}
		*A_0 = ref <Module>.??_7type_info@@6B@ + 4;
		<Module>.type_info._Type_info_dtor(A_0);
		if ((A_1 & 1u) != 0u)
		{
			<Module>.delete(A_0);
		}
		return A_0;
	}

	// Token: 0x0600006B RID: 107 RVA: 0x0000376C File Offset: 0x00002B6C
	[return: MarshalAs(UnmanagedType.U1)]
	internal unsafe static bool ==(type_info* A_0, type_info* rhs)
	{
		return ((<Module>.strcmp(rhs + 9, A_0 + 9) != 0) ? 0 : 1) != 0;
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00003790 File Offset: 0x00002B90
	[return: MarshalAs(UnmanagedType.U1)]
	internal unsafe static bool !=(type_info* A_0, type_info* rhs)
	{
		return ((<Module>.strcmp(rhs + 9, A_0 + 9) != 0) ? 1 : 0) != 0;
	}

	// Token: 0x0600006D RID: 109 RVA: 0x000037B4 File Offset: 0x00002BB4
	internal unsafe static int before(type_info* A_0, type_info* rhs)
	{
		return (<Module>.strcmp(rhs + 9, A_0 + 9) > 0) ? 1 : 0;
	}

	// Token: 0x0600006E RID: 110 RVA: 0x000037D4 File Offset: 0x00002BD4
	internal unsafe static sbyte* raw_name(type_info* A_0)
	{
		return A_0 + 8;
	}

	// Token: 0x0600006F RID: 111 RVA: 0x000037E4 File Offset: 0x00002BE4
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static void _Type_info_dtor(type_info* A_0)
	{
		bool flag = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				Thread.BeginThreadAffinity();
				<Module>._lock(14);
				flag = true;
			}
			uint num = (uint)(*(int*)(A_0 + 4 / sizeof(type_info)));
			if (num != 0u)
			{
				__type_info_node* ptr = *(ref <Module>.__type_info_root_node + 4);
				__type_info_node* ptr2 = &<Module>.__type_info_root_node;
				while (ptr != null)
				{
					if (*(int*)ptr == (int)num)
					{
						*(int*)(ptr2 + 4 / sizeof(__type_info_node)) = *(int*)(ptr + 4 / sizeof(__type_info_node));
						<Module>.free((void*)ptr);
						break;
					}
					ptr2 = ptr;
					ptr = ptr;
				}
				<Module>.free(*(int*)(A_0 + 4 / sizeof(type_info)));
				*(int*)(A_0 + 4 / sizeof(type_info)) = 0;
			}
		}
		finally
		{
			if (flag)
			{
				<Module>._unlock(14);
				Thread.EndThreadAffinity();
			}
		}
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00003898 File Offset: 0x00002C98
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static sbyte* _Name_base(type_info* __unnamed000, __type_info_node* __ptype_info_node)
	{
		if (*(int*)(__unnamed000 + 4 / sizeof(type_info)) == 0)
		{
			void* ptr = <Module>.__unDNameHelper(null, (sbyte*)(__unnamed000 + 9 / sizeof(type_info)), 0, 0);
			if (ptr == null)
			{
				return null;
			}
			uint num = <Module>.strlen((sbyte*)ptr);
			if (num > 0u)
			{
				do
				{
					num -= 1u;
					if (*(sbyte*)((byte*)ptr + num) != 32)
					{
						goto IL_3F;
					}
					((byte*)ptr)[num] = 0;
				}
				while (num > 0u);
			}
			num -= 1u;
			IL_3F:
			bool flag = false;
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				RuntimeHelpers.PrepareConstrainedRegions();
				try
				{
				}
				finally
				{
					Thread.BeginThreadAffinity();
					<Module>._lock(14);
					flag = true;
				}
				if (*(int*)(__unnamed000 + 4 / sizeof(type_info)) == 0)
				{
					__type_info_node* ptr2 = <Module>.malloc(8u);
					if (ptr2 != null)
					{
						void* ptr3 = <Module>.malloc(num + 2u);
						*(int*)(__unnamed000 + 4 / sizeof(type_info)) = ptr3;
						if (ptr3 != null)
						{
							if (<Module>.strcpy_s((sbyte*)ptr3, num + 2u, (sbyte*)ptr) != null)
							{
								<Module>._invoke_watson(null, null, null, 0u, 0u);
							}
							*(int*)ptr2 = *(int*)(__unnamed000 + 4 / sizeof(type_info));
							*(int*)(ptr2 + 4 / sizeof(__type_info_node)) = *(int*)(__ptype_info_node + 4 / sizeof(__type_info_node));
							*(int*)(__ptype_info_node + 4 / sizeof(__type_info_node)) = ptr2;
						}
						else
						{
							<Module>.free((void*)ptr2);
						}
					}
				}
				<Module>.free(ptr);
			}
			finally
			{
				if (flag)
				{
					<Module>._unlock(14);
					Thread.EndThreadAffinity();
				}
			}
		}
		return *(int*)(__unnamed000 + 4 / sizeof(type_info));
	}

	// Token: 0x06000071 RID: 113 RVA: 0x000039A8 File Offset: 0x00002DA8
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static void __clean_type_info_names_internal(__type_info_node* p_type_info_root_node)
	{
		bool flag = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				Thread.BeginThreadAffinity();
				<Module>._lock(14);
				flag = true;
			}
			__type_info_node* ptr2;
			for (__type_info_node* ptr = *(int*)(p_type_info_root_node + 4 / sizeof(__type_info_node)); ptr != null; ptr = ptr2)
			{
				ptr2 = *(int*)(ptr + 4 / sizeof(__type_info_node));
				<Module>.free(*(int*)ptr);
				<Module>.free((void*)ptr);
			}
		}
		finally
		{
			if (flag)
			{
				<Module>._unlock(14);
				Thread.EndThreadAffinity();
			}
		}
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00003A38 File Offset: 0x00002E38
	internal unsafe static void __clean_type_info_names()
	{
		<Module>.__clean_type_info_names_internal(&<Module>.__type_info_root_node);
	}

	// Token: 0x06000073 RID: 115 RVA: 0x0000CA40 File Offset: 0x0000BE40
	internal unsafe static void ??__E??_7type_info@@6B@@@YMXXZ()
	{
		<Module>.??_7type_info@@6B@ = ref <Module>.??_R4type_info@@6B@;
		*(ref <Module>.??_7type_info@@6B@ + 4) = (int)ldftn(type_info.__vecDelDtor);
	}

	// Token: 0x06000074 RID: 116 RVA: 0x0000C924 File Offset: 0x0000BD24
	internal unsafe static void ??__E??_R0?AVtype_info@@@8@@YMXXZ()
	{
		<Module>.??_R0?AVtype_info@@@8 = ref <Module>.??_7type_info@@6B@ + 4;
		*(ref <Module>.??_R0?AVtype_info@@@8 + 4) = 0;
		cpblk(ref <Module>.??_R0?AVtype_info@@@8 + 8, ref <Module>.??_C@_0BA@NOJDBDJO@?4?$DPAVtype_info?$EA?$EA?$AA@, 16);
	}

	// Token: 0x06000075 RID: 117 RVA: 0x0000C958 File Offset: 0x0000BD58
	internal unsafe static void ??__E??_R1A@?0A@EA@type_info@@8@@YMXXZ()
	{
		<Module>.??_R1A@?0A@EA@type_info@@8 = ref <Module>.??_R0?AVtype_info@@@8;
		*(ref <Module>.??_R1A@?0A@EA@type_info@@8 + 4) = 0;
		*(ref <Module>.??_R1A@?0A@EA@type_info@@8 + 8) = 0;
		*(ref <Module>.??_R1A@?0A@EA@type_info@@8 + 12) = -1;
		*(ref <Module>.??_R1A@?0A@EA@type_info@@8 + 16) = 0;
		*(ref <Module>.??_R1A@?0A@EA@type_info@@8 + 20) = 64;
		*(ref <Module>.??_R1A@?0A@EA@type_info@@8 + 24) = ref <Module>.??_R3type_info@@8;
	}

	// Token: 0x06000076 RID: 118 RVA: 0x0000C9B0 File Offset: 0x0000BDB0
	internal static void ??__E??_R2type_info@@8@@YMXXZ()
	{
		<Module>.??_R2type_info@@8 = ref <Module>.??_R1A@?0A@EA@type_info@@8;
	}

	// Token: 0x06000077 RID: 119 RVA: 0x0000C9C8 File Offset: 0x0000BDC8
	internal unsafe static void ??__E??_R3type_info@@8@@YMXXZ()
	{
		<Module>.??_R3type_info@@8 = 0;
		*(ref <Module>.??_R3type_info@@8 + 4) = 0;
		*(ref <Module>.??_R3type_info@@8 + 8) = 1;
		*(ref <Module>.??_R3type_info@@8 + 12) = ref <Module>.??_R2type_info@@8;
	}

	// Token: 0x06000078 RID: 120 RVA: 0x0000C9FC File Offset: 0x0000BDFC
	internal unsafe static void ??__E??_R4type_info@@6B@@@YMXXZ()
	{
		<Module>.??_R4type_info@@6B@ = 0;
		*(ref <Module>.??_R4type_info@@6B@ + 4) = 0;
		*(ref <Module>.??_R4type_info@@6B@ + 8) = 0;
		*(ref <Module>.??_R4type_info@@6B@ + 12) = ref <Module>.??_R0?AVtype_info@@@8;
		*(ref <Module>.??_R4type_info@@6B@ + 16) = ref <Module>.??_R3type_info@@8;
	}

	// Token: 0x06000079 RID: 121
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void _unlock(int _File);

	// Token: 0x0600007A RID: 122
	[SuppressUnmanagedCodeSecurity]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void _lock(int _File);

	// Token: 0x0600007B RID: 123 RVA: 0x0000CA68 File Offset: 0x0000BE68
	internal static void ??__E?A0x644ad69d@SA_Yes@@YMXXZ()
	{
		<Module>.?A0x644ad69d.SA_Yes = (YesNoMaybe)268370176;
	}

	// Token: 0x0600007C RID: 124 RVA: 0x0000CA80 File Offset: 0x0000BE80
	internal static void ??__E?A0x644ad69d@SA_No@@YMXXZ()
	{
		<Module>.?A0x644ad69d.SA_No = (YesNoMaybe)268369921;
	}

	// Token: 0x0600007D RID: 125 RVA: 0x0000CA98 File Offset: 0x0000BE98
	internal static void ??__E?A0x644ad69d@SA_Maybe@@YMXXZ()
	{
		<Module>.?A0x644ad69d.SA_Maybe = (YesNoMaybe)268369936;
	}

	// Token: 0x0600007E RID: 126 RVA: 0x0000CAB0 File Offset: 0x0000BEB0
	internal static void ??__E?A0x644ad69d@SA_NoAccess@@YMXXZ()
	{
		<Module>.?A0x644ad69d.SA_NoAccess = (AccessType)0;
	}

	// Token: 0x0600007F RID: 127 RVA: 0x0000CAC4 File Offset: 0x0000BEC4
	internal static void ??__E?A0x644ad69d@SA_Read@@YMXXZ()
	{
		<Module>.?A0x644ad69d.SA_Read = (AccessType)1;
	}

	// Token: 0x06000080 RID: 128 RVA: 0x0000CAD8 File Offset: 0x0000BED8
	internal static void ??__E?A0x644ad69d@SA_Write@@YMXXZ()
	{
		<Module>.?A0x644ad69d.SA_Write = (AccessType)2;
	}

	// Token: 0x06000081 RID: 129 RVA: 0x0000CAEC File Offset: 0x0000BEEC
	internal static void ??__E?A0x644ad69d@SA_ReadWrite@@YMXXZ()
	{
		<Module>.?A0x644ad69d.SA_ReadWrite = (AccessType)3;
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00003B44 File Offset: 0x00002F44
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static void __ehvec_dtor(void* ptr, uint size, int count, method pDtor)
	{
		int num = 0;
		ptr = (void*)(size * (uint)count + (byte*)ptr);
		try
		{
			for (;;)
			{
				count--;
				if (count < 0)
				{
					break;
				}
				ptr = (void*)((byte*)ptr - size);
				calli(System.Void(System.Void*), ptr, pDtor);
			}
			num = 1;
		}
		finally
		{
			if (num == 0)
			{
				<Module>.__ArrayUnwind(ptr, size, count, pDtor);
			}
		}
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00003AD0 File Offset: 0x00002ED0
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static int ArrayUnwindFilter(_EXCEPTION_POINTERS* pExPtrs)
	{
		if (*(*(int*)pExPtrs) != -529697949)
		{
			return 0;
		}
		<Module>.terminate();
		return 0;
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00003AF0 File Offset: 0x00002EF0
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static void __ArrayUnwind(void* ptr, uint size, int count, method pDtor)
	{
		try
		{
			for (;;)
			{
				count--;
				if (count < 0)
				{
					break;
				}
				ptr = (void*)((byte*)ptr - size);
				calli(System.Void(System.Void*), ptr, pDtor);
			}
		}
		catch when (endfilter(<Module>.?A0x644ad69d.ArrayUnwindFilter(Marshal.GetExceptionPointers()) != 0))
		{
		}
	}

	// Token: 0x06000085 RID: 133 RVA: 0x000075E0 File Offset: 0x000069E0
	internal unsafe static void ??__E?A0x1ed48d78@crc32_tab@@YMXXZ()
	{
		<Module>.?A0x1ed48d78.crc32_tab = 0;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 4) = 1996959894;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 8) = -301047508;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 12) = -1727442502;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 16) = 124634137;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 20) = 1886057615;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 24) = -379345611;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 28) = -1637575261;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 32) = 249268274;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 36) = 2044508324;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 40) = -522852066;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 44) = -1747789432;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 48) = 162941995;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 52) = 2125561021;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 56) = -407360249;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 60) = -1866523247;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 64) = 498536548;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 68) = 1789927666;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 72) = -205950648;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 76) = -2067906082;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 80) = 450548861;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 84) = 1843258603;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 88) = -187386543;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 92) = -2083289657;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 96) = 325883990;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 100) = 1684777152;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 104) = -43845254;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 108) = -1973040660;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 112) = 335633487;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 116) = 1661365465;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 120) = -99664541;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 124) = -1928851979;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 128) = 997073096;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 132) = 1281953886;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 136) = -715111964;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 140) = -1570279054;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 144) = 1006888145;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 148) = 1258607687;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 152) = -770865667;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 156) = -1526024853;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 160) = 901097722;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 164) = 1119000684;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 168) = -608450090;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 172) = -1396901568;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 176) = 853044451;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 180) = 1172266101;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 184) = -589951537;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 188) = -1412350631;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 192) = 651767980;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 196) = 1373503546;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 200) = -925412992;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 204) = -1076862698;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 208) = 565507253;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 212) = 1454621731;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 216) = -809855591;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 220) = -1195530993;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 224) = 671266974;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 228) = 1594198024;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 232) = -972236366;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 236) = -1324619484;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 240) = 795835527;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 244) = 1483230225;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 248) = -1050600021;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 252) = -1234817731;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 256) = 1994146192;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 260) = 31158534;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 264) = -1731059524;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 268) = -271249366;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 272) = 1907459465;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 276) = 112637215;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 280) = -1614814043;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 284) = -390540237;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 288) = 2013776290;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 292) = 251722036;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 296) = -1777751922;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 300) = -519137256;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 304) = 2137656763;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 308) = 141376813;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 312) = -1855689577;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 316) = -429695999;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 320) = 1802195444;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 324) = 476864866;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 328) = -2056965928;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 332) = -228458418;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 336) = 1812370925;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 340) = 453092731;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 344) = -2113342271;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 348) = -183516073;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 352) = 1706088902;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 356) = 314042704;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 360) = -1950435094;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 364) = -54949764;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 368) = 1658658271;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 372) = 366619977;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 376) = -1932296973;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 380) = -69972891;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 384) = 1303535960;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 388) = 984961486;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 392) = -1547960204;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 396) = -725929758;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 400) = 1256170817;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 404) = 1037604311;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 408) = -1529756563;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 412) = -740887301;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 416) = 1131014506;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 420) = 879679996;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 424) = -1385723834;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 428) = -631195440;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 432) = 1141124467;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 436) = 855842277;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 440) = -1442165665;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 444) = -586318647;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 448) = 1342533948;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 452) = 654459306;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 456) = -1106571248;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 460) = -921952122;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 464) = 1466479909;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 468) = 544179635;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 472) = -1184443383;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 476) = -832445281;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 480) = 1591671054;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 484) = 702138776;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 488) = -1328506846;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 492) = -942167884;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 496) = 1504918807;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 500) = 783551873;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 504) = -1212326853;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 508) = -1061524307;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 512) = -306674912;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 516) = -1698712650;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 520) = 62317068;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 524) = 1957810842;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 528) = -355121351;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 532) = -1647151185;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 536) = 81470997;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 540) = 1943803523;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 544) = -480048366;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 548) = -1805370492;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 552) = 225274430;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 556) = 2053790376;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 560) = -468791541;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 564) = -1828061283;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 568) = 167816743;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 572) = 2097651377;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 576) = -267414716;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 580) = -2029476910;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 584) = 503444072;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 588) = 1762050814;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 592) = -144550051;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 596) = -2140837941;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 600) = 426522225;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 604) = 1852507879;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 608) = -19653770;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 612) = -1982649376;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 616) = 282753626;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 620) = 1742555852;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 624) = -105259153;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 628) = -1900089351;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 632) = 397917763;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 636) = 1622183637;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 640) = -690576408;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 644) = -1580100738;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 648) = 953729732;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 652) = 1340076626;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 656) = -776247311;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 660) = -1497606297;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 664) = 1068828381;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 668) = 1219638859;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 672) = -670225446;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 676) = -1358292148;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 680) = 906185462;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 684) = 1090812512;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 688) = -547295293;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 692) = -1469587627;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 696) = 829329135;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 700) = 1181335161;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 704) = -882789492;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 708) = -1134132454;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 712) = 628085408;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 716) = 1382605366;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 720) = -871598187;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 724) = -1156888829;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 728) = 570562233;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 732) = 1426400815;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 736) = -977650754;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 740) = -1296233688;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 744) = 733239954;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 748) = 1555261956;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 752) = -1026031705;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 756) = -1244606671;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 760) = 752459403;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 764) = 1541320221;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 768) = -1687895376;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 772) = -328994266;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 776) = 1969922972;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 780) = 40735498;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 784) = -1677130071;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 788) = -351390145;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 792) = 1913087877;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 796) = 83908371;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 800) = -1782625662;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 804) = -491226604;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 808) = 2075208622;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 812) = 213261112;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 816) = -1831694693;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 820) = -438977011;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 824) = 2094854071;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 828) = 198958881;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 832) = -2032938284;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 836) = -237706686;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 840) = 1759359992;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 844) = 534414190;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 848) = -2118248755;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 852) = -155638181;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 856) = 1873836001;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 860) = 414664567;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 864) = -2012718362;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 868) = -15766928;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 872) = 1711684554;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 876) = 285281116;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 880) = -1889165569;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 884) = -127750551;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 888) = 1634467795;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 892) = 376229701;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 896) = -1609899400;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 900) = -686959890;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 904) = 1308918612;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 908) = 956543938;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 912) = -1486412191;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 916) = -799009033;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 920) = 1231636301;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 924) = 1047427035;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 928) = -1362007478;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 932) = -640263460;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 936) = 1088359270;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 940) = 936918000;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 944) = -1447252397;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 948) = -558129467;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 952) = 1202900863;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 956) = 817233897;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 960) = -1111625188;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 964) = -893730166;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 968) = 1404277552;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 972) = 615818150;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 976) = -1160759803;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 980) = -841546093;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 984) = 1423857449;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 988) = 601450431;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 992) = -1285129682;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 996) = -1000256840;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 1000) = 1567103746;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 1004) = 711928724;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 1008) = -1274298825;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 1012) = -1022587231;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 1016) = 1510334235;
		*(ref <Module>.?A0x1ed48d78.crc32_tab + 1020) = 755167117;
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00007574 File Offset: 0x00006974
	internal unsafe static uint crc32(byte* s, uint len, uint initcrc)
	{
		uint num = initcrc;
		for (uint num2 = 0u; num2 < len; num2 += 1u)
		{
			num = (*(ref <Module>.?A0x1ed48d78.crc32_tab + ((num ^ *(byte*)(s + num2 / (uint)sizeof(byte))) & 255) * 4) ^ num >> 8);
		}
		return num;
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00008684 File Offset: 0x00007A84
	internal static void ??__E?A0x0832d670@SA_Yes@@YMXXZ()
	{
		<Module>.?A0x0832d670.SA_Yes = (YesNoMaybe)268370176;
	}

	// Token: 0x06000088 RID: 136 RVA: 0x0000869C File Offset: 0x00007A9C
	internal static void ??__E?A0x0832d670@SA_No@@YMXXZ()
	{
		<Module>.?A0x0832d670.SA_No = (YesNoMaybe)268369921;
	}

	// Token: 0x06000089 RID: 137 RVA: 0x000086B4 File Offset: 0x00007AB4
	internal static void ??__E?A0x0832d670@SA_Maybe@@YMXXZ()
	{
		<Module>.?A0x0832d670.SA_Maybe = (YesNoMaybe)268369936;
	}

	// Token: 0x0600008A RID: 138 RVA: 0x000086CC File Offset: 0x00007ACC
	internal static void ??__E?A0x0832d670@SA_NoAccess@@YMXXZ()
	{
		<Module>.?A0x0832d670.SA_NoAccess = (AccessType)0;
	}

	// Token: 0x0600008B RID: 139 RVA: 0x000086E0 File Offset: 0x00007AE0
	internal static void ??__E?A0x0832d670@SA_Read@@YMXXZ()
	{
		<Module>.?A0x0832d670.SA_Read = (AccessType)1;
	}

	// Token: 0x0600008C RID: 140 RVA: 0x000086F4 File Offset: 0x00007AF4
	internal static void ??__E?A0x0832d670@SA_Write@@YMXXZ()
	{
		<Module>.?A0x0832d670.SA_Write = (AccessType)2;
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00008708 File Offset: 0x00007B08
	internal static void ??__E?A0x0832d670@SA_ReadWrite@@YMXXZ()
	{
		<Module>.?A0x0832d670.SA_ReadWrite = (AccessType)3;
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00006E80 File Offset: 0x00006280
	internal unsafe static int working_memcmp(sbyte* a, sbyte* b, uint n)
	{
		while (n != 0u)
		{
			if (*(sbyte*)a != *(sbyte*)b)
			{
				return (int)(*(byte*)a - *(byte*)b);
			}
			n -= 1u;
			a += 1 / sizeof(sbyte);
			b += 1 / sizeof(sbyte);
		}
		return 0;
	}

	// Token: 0x0600008F RID: 143 RVA: 0x0000871C File Offset: 0x00007B1C
	internal unsafe static void ??__E?A0x0832d670@sbox1@@YMXXZ()
	{
		<Module>.?A0x0832d670.sbox1 = 8421888;
		*(ref <Module>.?A0x0832d670.sbox1 + 4) = 0;
		*(ref <Module>.?A0x0832d670.sbox1 + 8) = 32768;
		*(ref <Module>.?A0x0832d670.sbox1 + 12) = 8421890;
		*(ref <Module>.?A0x0832d670.sbox1 + 16) = 8421378;
		*(ref <Module>.?A0x0832d670.sbox1 + 20) = 33282;
		*(ref <Module>.?A0x0832d670.sbox1 + 24) = 2;
		*(ref <Module>.?A0x0832d670.sbox1 + 28) = 32768;
		*(ref <Module>.?A0x0832d670.sbox1 + 32) = 512;
		*(ref <Module>.?A0x0832d670.sbox1 + 36) = 8421888;
		*(ref <Module>.?A0x0832d670.sbox1 + 40) = 8421890;
		*(ref <Module>.?A0x0832d670.sbox1 + 44) = 512;
		*(ref <Module>.?A0x0832d670.sbox1 + 48) = 8389122;
		*(ref <Module>.?A0x0832d670.sbox1 + 52) = 8421378;
		*(ref <Module>.?A0x0832d670.sbox1 + 56) = 8388608;
		*(ref <Module>.?A0x0832d670.sbox1 + 60) = 2;
		*(ref <Module>.?A0x0832d670.sbox1 + 64) = 514;
		*(ref <Module>.?A0x0832d670.sbox1 + 68) = 8389120;
		*(ref <Module>.?A0x0832d670.sbox1 + 72) = 8389120;
		*(ref <Module>.?A0x0832d670.sbox1 + 76) = 33280;
		*(ref <Module>.?A0x0832d670.sbox1 + 80) = 33280;
		*(ref <Module>.?A0x0832d670.sbox1 + 84) = 8421376;
		*(ref <Module>.?A0x0832d670.sbox1 + 88) = 8421376;
		*(ref <Module>.?A0x0832d670.sbox1 + 92) = 8389122;
		*(ref <Module>.?A0x0832d670.sbox1 + 96) = 32770;
		*(ref <Module>.?A0x0832d670.sbox1 + 100) = 8388610;
		*(ref <Module>.?A0x0832d670.sbox1 + 104) = 8388610;
		*(ref <Module>.?A0x0832d670.sbox1 + 108) = 32770;
		*(ref <Module>.?A0x0832d670.sbox1 + 112) = 0;
		*(ref <Module>.?A0x0832d670.sbox1 + 116) = 514;
		*(ref <Module>.?A0x0832d670.sbox1 + 120) = 33282;
		*(ref <Module>.?A0x0832d670.sbox1 + 124) = 8388608;
		*(ref <Module>.?A0x0832d670.sbox1 + 128) = 32768;
		*(ref <Module>.?A0x0832d670.sbox1 + 132) = 8421890;
		*(ref <Module>.?A0x0832d670.sbox1 + 136) = 2;
		*(ref <Module>.?A0x0832d670.sbox1 + 140) = 8421376;
		*(ref <Module>.?A0x0832d670.sbox1 + 144) = 8421888;
		*(ref <Module>.?A0x0832d670.sbox1 + 148) = 8388608;
		*(ref <Module>.?A0x0832d670.sbox1 + 152) = 8388608;
		*(ref <Module>.?A0x0832d670.sbox1 + 156) = 512;
		*(ref <Module>.?A0x0832d670.sbox1 + 160) = 8421378;
		*(ref <Module>.?A0x0832d670.sbox1 + 164) = 32768;
		*(ref <Module>.?A0x0832d670.sbox1 + 168) = 33280;
		*(ref <Module>.?A0x0832d670.sbox1 + 172) = 8388610;
		*(ref <Module>.?A0x0832d670.sbox1 + 176) = 512;
		*(ref <Module>.?A0x0832d670.sbox1 + 180) = 2;
		*(ref <Module>.?A0x0832d670.sbox1 + 184) = 8389122;
		*(ref <Module>.?A0x0832d670.sbox1 + 188) = 33282;
		*(ref <Module>.?A0x0832d670.sbox1 + 192) = 8421890;
		*(ref <Module>.?A0x0832d670.sbox1 + 196) = 32770;
		*(ref <Module>.?A0x0832d670.sbox1 + 200) = 8421376;
		*(ref <Module>.?A0x0832d670.sbox1 + 204) = 8389122;
		*(ref <Module>.?A0x0832d670.sbox1 + 208) = 8388610;
		*(ref <Module>.?A0x0832d670.sbox1 + 212) = 514;
		*(ref <Module>.?A0x0832d670.sbox1 + 216) = 33282;
		*(ref <Module>.?A0x0832d670.sbox1 + 220) = 8421888;
		*(ref <Module>.?A0x0832d670.sbox1 + 224) = 514;
		*(ref <Module>.?A0x0832d670.sbox1 + 228) = 8389120;
		*(ref <Module>.?A0x0832d670.sbox1 + 232) = 8389120;
		*(ref <Module>.?A0x0832d670.sbox1 + 236) = 0;
		*(ref <Module>.?A0x0832d670.sbox1 + 240) = 32770;
		*(ref <Module>.?A0x0832d670.sbox1 + 244) = 33280;
		*(ref <Module>.?A0x0832d670.sbox1 + 248) = 0;
		*(ref <Module>.?A0x0832d670.sbox1 + 252) = 8421378;
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00008AE4 File Offset: 0x00007EE4
	internal unsafe static void ??__E?A0x0832d670@sbox2@@YMXXZ()
	{
		<Module>.?A0x0832d670.sbox2 = 1074282512;
		*(ref <Module>.?A0x0832d670.sbox2 + 4) = 1073758208;
		*(ref <Module>.?A0x0832d670.sbox2 + 8) = 16384;
		*(ref <Module>.?A0x0832d670.sbox2 + 12) = 540688;
		*(ref <Module>.?A0x0832d670.sbox2 + 16) = 524288;
		*(ref <Module>.?A0x0832d670.sbox2 + 20) = 16;
		*(ref <Module>.?A0x0832d670.sbox2 + 24) = 1074266128;
		*(ref <Module>.?A0x0832d670.sbox2 + 28) = 1073758224;
		*(ref <Module>.?A0x0832d670.sbox2 + 32) = 1073741840;
		*(ref <Module>.?A0x0832d670.sbox2 + 36) = 1074282512;
		*(ref <Module>.?A0x0832d670.sbox2 + 40) = 1074282496;
		*(ref <Module>.?A0x0832d670.sbox2 + 44) = 1073741824;
		*(ref <Module>.?A0x0832d670.sbox2 + 48) = 1073758208;
		*(ref <Module>.?A0x0832d670.sbox2 + 52) = 524288;
		*(ref <Module>.?A0x0832d670.sbox2 + 56) = 16;
		*(ref <Module>.?A0x0832d670.sbox2 + 60) = 1074266128;
		*(ref <Module>.?A0x0832d670.sbox2 + 64) = 540672;
		*(ref <Module>.?A0x0832d670.sbox2 + 68) = 524304;
		*(ref <Module>.?A0x0832d670.sbox2 + 72) = 1073758224;
		*(ref <Module>.?A0x0832d670.sbox2 + 76) = 0;
		*(ref <Module>.?A0x0832d670.sbox2 + 80) = 1073741824;
		*(ref <Module>.?A0x0832d670.sbox2 + 84) = 16384;
		*(ref <Module>.?A0x0832d670.sbox2 + 88) = 540688;
		*(ref <Module>.?A0x0832d670.sbox2 + 92) = 1074266112;
		*(ref <Module>.?A0x0832d670.sbox2 + 96) = 524304;
		*(ref <Module>.?A0x0832d670.sbox2 + 100) = 1073741840;
		*(ref <Module>.?A0x0832d670.sbox2 + 104) = 0;
		*(ref <Module>.?A0x0832d670.sbox2 + 108) = 540672;
		*(ref <Module>.?A0x0832d670.sbox2 + 112) = 16400;
		*(ref <Module>.?A0x0832d670.sbox2 + 116) = 1074282496;
		*(ref <Module>.?A0x0832d670.sbox2 + 120) = 1074266112;
		*(ref <Module>.?A0x0832d670.sbox2 + 124) = 16400;
		*(ref <Module>.?A0x0832d670.sbox2 + 128) = 0;
		*(ref <Module>.?A0x0832d670.sbox2 + 132) = 540688;
		*(ref <Module>.?A0x0832d670.sbox2 + 136) = 1074266128;
		*(ref <Module>.?A0x0832d670.sbox2 + 140) = 524288;
		*(ref <Module>.?A0x0832d670.sbox2 + 144) = 1073758224;
		*(ref <Module>.?A0x0832d670.sbox2 + 148) = 1074266112;
		*(ref <Module>.?A0x0832d670.sbox2 + 152) = 1074282496;
		*(ref <Module>.?A0x0832d670.sbox2 + 156) = 16384;
		*(ref <Module>.?A0x0832d670.sbox2 + 160) = 1074266112;
		*(ref <Module>.?A0x0832d670.sbox2 + 164) = 1073758208;
		*(ref <Module>.?A0x0832d670.sbox2 + 168) = 16;
		*(ref <Module>.?A0x0832d670.sbox2 + 172) = 1074282512;
		*(ref <Module>.?A0x0832d670.sbox2 + 176) = 540688;
		*(ref <Module>.?A0x0832d670.sbox2 + 180) = 16;
		*(ref <Module>.?A0x0832d670.sbox2 + 184) = 16384;
		*(ref <Module>.?A0x0832d670.sbox2 + 188) = 1073741824;
		*(ref <Module>.?A0x0832d670.sbox2 + 192) = 16400;
		*(ref <Module>.?A0x0832d670.sbox2 + 196) = 1074282496;
		*(ref <Module>.?A0x0832d670.sbox2 + 200) = 524288;
		*(ref <Module>.?A0x0832d670.sbox2 + 204) = 1073741840;
		*(ref <Module>.?A0x0832d670.sbox2 + 208) = 524304;
		*(ref <Module>.?A0x0832d670.sbox2 + 212) = 1073758224;
		*(ref <Module>.?A0x0832d670.sbox2 + 216) = 1073741840;
		*(ref <Module>.?A0x0832d670.sbox2 + 220) = 524304;
		*(ref <Module>.?A0x0832d670.sbox2 + 224) = 540672;
		*(ref <Module>.?A0x0832d670.sbox2 + 228) = 0;
		*(ref <Module>.?A0x0832d670.sbox2 + 232) = 1073758208;
		*(ref <Module>.?A0x0832d670.sbox2 + 236) = 16400;
		*(ref <Module>.?A0x0832d670.sbox2 + 240) = 1073741824;
		*(ref <Module>.?A0x0832d670.sbox2 + 244) = 1074266128;
		*(ref <Module>.?A0x0832d670.sbox2 + 248) = 1074282512;
		*(ref <Module>.?A0x0832d670.sbox2 + 252) = 540672;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00008EB0 File Offset: 0x000082B0
	internal unsafe static void ??__E?A0x0832d670@sbox3@@YMXXZ()
	{
		<Module>.?A0x0832d670.sbox3 = 260;
		*(ref <Module>.?A0x0832d670.sbox3 + 4) = 67174656;
		*(ref <Module>.?A0x0832d670.sbox3 + 8) = 0;
		*(ref <Module>.?A0x0832d670.sbox3 + 12) = 67174404;
		*(ref <Module>.?A0x0832d670.sbox3 + 16) = 67109120;
		*(ref <Module>.?A0x0832d670.sbox3 + 20) = 0;
		*(ref <Module>.?A0x0832d670.sbox3 + 24) = 65796;
		*(ref <Module>.?A0x0832d670.sbox3 + 28) = 67109120;
		*(ref <Module>.?A0x0832d670.sbox3 + 32) = 65540;
		*(ref <Module>.?A0x0832d670.sbox3 + 36) = 67108868;
		*(ref <Module>.?A0x0832d670.sbox3 + 40) = 67108868;
		*(ref <Module>.?A0x0832d670.sbox3 + 44) = 65536;
		*(ref <Module>.?A0x0832d670.sbox3 + 48) = 67174660;
		*(ref <Module>.?A0x0832d670.sbox3 + 52) = 65540;
		*(ref <Module>.?A0x0832d670.sbox3 + 56) = 67174400;
		*(ref <Module>.?A0x0832d670.sbox3 + 60) = 260;
		*(ref <Module>.?A0x0832d670.sbox3 + 64) = 67108864;
		*(ref <Module>.?A0x0832d670.sbox3 + 68) = 4;
		*(ref <Module>.?A0x0832d670.sbox3 + 72) = 67174656;
		*(ref <Module>.?A0x0832d670.sbox3 + 76) = 256;
		*(ref <Module>.?A0x0832d670.sbox3 + 80) = 65792;
		*(ref <Module>.?A0x0832d670.sbox3 + 84) = 67174400;
		*(ref <Module>.?A0x0832d670.sbox3 + 88) = 67174404;
		*(ref <Module>.?A0x0832d670.sbox3 + 92) = 65796;
		*(ref <Module>.?A0x0832d670.sbox3 + 96) = 67109124;
		*(ref <Module>.?A0x0832d670.sbox3 + 100) = 65792;
		*(ref <Module>.?A0x0832d670.sbox3 + 104) = 65536;
		*(ref <Module>.?A0x0832d670.sbox3 + 108) = 67109124;
		*(ref <Module>.?A0x0832d670.sbox3 + 112) = 4;
		*(ref <Module>.?A0x0832d670.sbox3 + 116) = 67174660;
		*(ref <Module>.?A0x0832d670.sbox3 + 120) = 256;
		*(ref <Module>.?A0x0832d670.sbox3 + 124) = 67108864;
		*(ref <Module>.?A0x0832d670.sbox3 + 128) = 67174656;
		*(ref <Module>.?A0x0832d670.sbox3 + 132) = 67108864;
		*(ref <Module>.?A0x0832d670.sbox3 + 136) = 65540;
		*(ref <Module>.?A0x0832d670.sbox3 + 140) = 260;
		*(ref <Module>.?A0x0832d670.sbox3 + 144) = 65536;
		*(ref <Module>.?A0x0832d670.sbox3 + 148) = 67174656;
		*(ref <Module>.?A0x0832d670.sbox3 + 152) = 67109120;
		*(ref <Module>.?A0x0832d670.sbox3 + 156) = 0;
		*(ref <Module>.?A0x0832d670.sbox3 + 160) = 256;
		*(ref <Module>.?A0x0832d670.sbox3 + 164) = 65540;
		*(ref <Module>.?A0x0832d670.sbox3 + 168) = 67174660;
		*(ref <Module>.?A0x0832d670.sbox3 + 172) = 67109120;
		*(ref <Module>.?A0x0832d670.sbox3 + 176) = 67108868;
		*(ref <Module>.?A0x0832d670.sbox3 + 180) = 256;
		*(ref <Module>.?A0x0832d670.sbox3 + 184) = 0;
		*(ref <Module>.?A0x0832d670.sbox3 + 188) = 67174404;
		*(ref <Module>.?A0x0832d670.sbox3 + 192) = 67109124;
		*(ref <Module>.?A0x0832d670.sbox3 + 196) = 65536;
		*(ref <Module>.?A0x0832d670.sbox3 + 200) = 67108864;
		*(ref <Module>.?A0x0832d670.sbox3 + 204) = 67174660;
		*(ref <Module>.?A0x0832d670.sbox3 + 208) = 4;
		*(ref <Module>.?A0x0832d670.sbox3 + 212) = 65796;
		*(ref <Module>.?A0x0832d670.sbox3 + 216) = 65792;
		*(ref <Module>.?A0x0832d670.sbox3 + 220) = 67108868;
		*(ref <Module>.?A0x0832d670.sbox3 + 224) = 67174400;
		*(ref <Module>.?A0x0832d670.sbox3 + 228) = 67109124;
		*(ref <Module>.?A0x0832d670.sbox3 + 232) = 260;
		*(ref <Module>.?A0x0832d670.sbox3 + 236) = 67174400;
		*(ref <Module>.?A0x0832d670.sbox3 + 240) = 65796;
		*(ref <Module>.?A0x0832d670.sbox3 + 244) = 4;
		*(ref <Module>.?A0x0832d670.sbox3 + 248) = 67174404;
		*(ref <Module>.?A0x0832d670.sbox3 + 252) = 65792;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00009278 File Offset: 0x00008678
	internal unsafe static void ??__E?A0x0832d670@sbox4@@YMXXZ()
	{
		<Module>.?A0x0832d670.sbox4 = -2143285248;
		*(ref <Module>.?A0x0832d670.sbox4 + 4) = -2147479488;
		*(ref <Module>.?A0x0832d670.sbox4 + 8) = -2147479488;
		*(ref <Module>.?A0x0832d670.sbox4 + 12) = 64;
		*(ref <Module>.?A0x0832d670.sbox4 + 16) = 4198464;
		*(ref <Module>.?A0x0832d670.sbox4 + 20) = -2143289280;
		*(ref <Module>.?A0x0832d670.sbox4 + 24) = -2143289344;
		*(ref <Module>.?A0x0832d670.sbox4 + 28) = -2147479552;
		*(ref <Module>.?A0x0832d670.sbox4 + 32) = 0;
		*(ref <Module>.?A0x0832d670.sbox4 + 36) = 4198400;
		*(ref <Module>.?A0x0832d670.sbox4 + 40) = 4198400;
		*(ref <Module>.?A0x0832d670.sbox4 + 44) = -2143285184;
		*(ref <Module>.?A0x0832d670.sbox4 + 48) = -2147483584;
		*(ref <Module>.?A0x0832d670.sbox4 + 52) = 0;
		*(ref <Module>.?A0x0832d670.sbox4 + 56) = 4194368;
		*(ref <Module>.?A0x0832d670.sbox4 + 60) = -2143289344;
		*(ref <Module>.?A0x0832d670.sbox4 + 64) = int.MinValue;
		*(ref <Module>.?A0x0832d670.sbox4 + 68) = 4096;
		*(ref <Module>.?A0x0832d670.sbox4 + 72) = 4194304;
		*(ref <Module>.?A0x0832d670.sbox4 + 76) = -2143285248;
		*(ref <Module>.?A0x0832d670.sbox4 + 80) = 64;
		*(ref <Module>.?A0x0832d670.sbox4 + 84) = 4194304;
		*(ref <Module>.?A0x0832d670.sbox4 + 88) = -2147479552;
		*(ref <Module>.?A0x0832d670.sbox4 + 92) = 4160;
		*(ref <Module>.?A0x0832d670.sbox4 + 96) = -2143289280;
		*(ref <Module>.?A0x0832d670.sbox4 + 100) = int.MinValue;
		*(ref <Module>.?A0x0832d670.sbox4 + 104) = 4160;
		*(ref <Module>.?A0x0832d670.sbox4 + 108) = 4194368;
		*(ref <Module>.?A0x0832d670.sbox4 + 112) = 4096;
		*(ref <Module>.?A0x0832d670.sbox4 + 116) = 4198464;
		*(ref <Module>.?A0x0832d670.sbox4 + 120) = -2143285184;
		*(ref <Module>.?A0x0832d670.sbox4 + 124) = -2147483584;
		*(ref <Module>.?A0x0832d670.sbox4 + 128) = 4194368;
		*(ref <Module>.?A0x0832d670.sbox4 + 132) = -2143289344;
		*(ref <Module>.?A0x0832d670.sbox4 + 136) = 4198400;
		*(ref <Module>.?A0x0832d670.sbox4 + 140) = -2143285184;
		*(ref <Module>.?A0x0832d670.sbox4 + 144) = -2147483584;
		*(ref <Module>.?A0x0832d670.sbox4 + 148) = 0;
		*(ref <Module>.?A0x0832d670.sbox4 + 152) = 0;
		*(ref <Module>.?A0x0832d670.sbox4 + 156) = 4198400;
		*(ref <Module>.?A0x0832d670.sbox4 + 160) = 4160;
		*(ref <Module>.?A0x0832d670.sbox4 + 164) = 4194368;
		*(ref <Module>.?A0x0832d670.sbox4 + 168) = -2143289280;
		*(ref <Module>.?A0x0832d670.sbox4 + 172) = int.MinValue;
		*(ref <Module>.?A0x0832d670.sbox4 + 176) = -2143285248;
		*(ref <Module>.?A0x0832d670.sbox4 + 180) = -2147479488;
		*(ref <Module>.?A0x0832d670.sbox4 + 184) = -2147479488;
		*(ref <Module>.?A0x0832d670.sbox4 + 188) = 64;
		*(ref <Module>.?A0x0832d670.sbox4 + 192) = -2143285184;
		*(ref <Module>.?A0x0832d670.sbox4 + 196) = -2147483584;
		*(ref <Module>.?A0x0832d670.sbox4 + 200) = int.MinValue;
		*(ref <Module>.?A0x0832d670.sbox4 + 204) = 4096;
		*(ref <Module>.?A0x0832d670.sbox4 + 208) = -2143289344;
		*(ref <Module>.?A0x0832d670.sbox4 + 212) = -2147479552;
		*(ref <Module>.?A0x0832d670.sbox4 + 216) = 4198464;
		*(ref <Module>.?A0x0832d670.sbox4 + 220) = -2143289280;
		*(ref <Module>.?A0x0832d670.sbox4 + 224) = -2147479552;
		*(ref <Module>.?A0x0832d670.sbox4 + 228) = 4160;
		*(ref <Module>.?A0x0832d670.sbox4 + 232) = 4194304;
		*(ref <Module>.?A0x0832d670.sbox4 + 236) = -2143285248;
		*(ref <Module>.?A0x0832d670.sbox4 + 240) = 64;
		*(ref <Module>.?A0x0832d670.sbox4 + 244) = 4194304;
		*(ref <Module>.?A0x0832d670.sbox4 + 248) = 4096;
		*(ref <Module>.?A0x0832d670.sbox4 + 252) = 4198464;
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00009644 File Offset: 0x00008A44
	internal unsafe static void ??__E?A0x0832d670@sbox5@@YMXXZ()
	{
		<Module>.?A0x0832d670.sbox5 = 128;
		*(ref <Module>.?A0x0832d670.sbox5 + 4) = 17039488;
		*(ref <Module>.?A0x0832d670.sbox5 + 8) = 17039360;
		*(ref <Module>.?A0x0832d670.sbox5 + 12) = 553648256;
		*(ref <Module>.?A0x0832d670.sbox5 + 16) = 262144;
		*(ref <Module>.?A0x0832d670.sbox5 + 20) = 128;
		*(ref <Module>.?A0x0832d670.sbox5 + 24) = 536870912;
		*(ref <Module>.?A0x0832d670.sbox5 + 28) = 17039360;
		*(ref <Module>.?A0x0832d670.sbox5 + 32) = 537133184;
		*(ref <Module>.?A0x0832d670.sbox5 + 36) = 262144;
		*(ref <Module>.?A0x0832d670.sbox5 + 40) = 16777344;
		*(ref <Module>.?A0x0832d670.sbox5 + 44) = 537133184;
		*(ref <Module>.?A0x0832d670.sbox5 + 48) = 553648256;
		*(ref <Module>.?A0x0832d670.sbox5 + 52) = 553910272;
		*(ref <Module>.?A0x0832d670.sbox5 + 56) = 262272;
		*(ref <Module>.?A0x0832d670.sbox5 + 60) = 536870912;
		*(ref <Module>.?A0x0832d670.sbox5 + 64) = 16777216;
		*(ref <Module>.?A0x0832d670.sbox5 + 68) = 537133056;
		*(ref <Module>.?A0x0832d670.sbox5 + 72) = 537133056;
		*(ref <Module>.?A0x0832d670.sbox5 + 76) = 0;
		*(ref <Module>.?A0x0832d670.sbox5 + 80) = 536871040;
		*(ref <Module>.?A0x0832d670.sbox5 + 84) = 553910400;
		*(ref <Module>.?A0x0832d670.sbox5 + 88) = 553910400;
		*(ref <Module>.?A0x0832d670.sbox5 + 92) = 16777344;
		*(ref <Module>.?A0x0832d670.sbox5 + 96) = 553910272;
		*(ref <Module>.?A0x0832d670.sbox5 + 100) = 536871040;
		*(ref <Module>.?A0x0832d670.sbox5 + 104) = 0;
		*(ref <Module>.?A0x0832d670.sbox5 + 108) = 553648128;
		*(ref <Module>.?A0x0832d670.sbox5 + 112) = 17039488;
		*(ref <Module>.?A0x0832d670.sbox5 + 116) = 16777216;
		*(ref <Module>.?A0x0832d670.sbox5 + 120) = 553648128;
		*(ref <Module>.?A0x0832d670.sbox5 + 124) = 262272;
		*(ref <Module>.?A0x0832d670.sbox5 + 128) = 262144;
		*(ref <Module>.?A0x0832d670.sbox5 + 132) = 553648256;
		*(ref <Module>.?A0x0832d670.sbox5 + 136) = 128;
		*(ref <Module>.?A0x0832d670.sbox5 + 140) = 16777216;
		*(ref <Module>.?A0x0832d670.sbox5 + 144) = 536870912;
		*(ref <Module>.?A0x0832d670.sbox5 + 148) = 17039360;
		*(ref <Module>.?A0x0832d670.sbox5 + 152) = 553648256;
		*(ref <Module>.?A0x0832d670.sbox5 + 156) = 537133184;
		*(ref <Module>.?A0x0832d670.sbox5 + 160) = 16777344;
		*(ref <Module>.?A0x0832d670.sbox5 + 164) = 536870912;
		*(ref <Module>.?A0x0832d670.sbox5 + 168) = 553910272;
		*(ref <Module>.?A0x0832d670.sbox5 + 172) = 17039488;
		*(ref <Module>.?A0x0832d670.sbox5 + 176) = 537133184;
		*(ref <Module>.?A0x0832d670.sbox5 + 180) = 128;
		*(ref <Module>.?A0x0832d670.sbox5 + 184) = 16777216;
		*(ref <Module>.?A0x0832d670.sbox5 + 188) = 553910272;
		*(ref <Module>.?A0x0832d670.sbox5 + 192) = 553910400;
		*(ref <Module>.?A0x0832d670.sbox5 + 196) = 262272;
		*(ref <Module>.?A0x0832d670.sbox5 + 200) = 553648128;
		*(ref <Module>.?A0x0832d670.sbox5 + 204) = 553910400;
		*(ref <Module>.?A0x0832d670.sbox5 + 208) = 17039360;
		*(ref <Module>.?A0x0832d670.sbox5 + 212) = 0;
		*(ref <Module>.?A0x0832d670.sbox5 + 216) = 537133056;
		*(ref <Module>.?A0x0832d670.sbox5 + 220) = 553648128;
		*(ref <Module>.?A0x0832d670.sbox5 + 224) = 262272;
		*(ref <Module>.?A0x0832d670.sbox5 + 228) = 16777344;
		*(ref <Module>.?A0x0832d670.sbox5 + 232) = 536871040;
		*(ref <Module>.?A0x0832d670.sbox5 + 236) = 262144;
		*(ref <Module>.?A0x0832d670.sbox5 + 240) = 0;
		*(ref <Module>.?A0x0832d670.sbox5 + 244) = 537133056;
		*(ref <Module>.?A0x0832d670.sbox5 + 248) = 17039488;
		*(ref <Module>.?A0x0832d670.sbox5 + 252) = 536871040;
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00009A1C File Offset: 0x00008E1C
	internal unsafe static void ??__E?A0x0832d670@sbox6@@YMXXZ()
	{
		<Module>.?A0x0832d670.sbox6 = 268435464;
		*(ref <Module>.?A0x0832d670.sbox6 + 4) = 270532608;
		*(ref <Module>.?A0x0832d670.sbox6 + 8) = 8192;
		*(ref <Module>.?A0x0832d670.sbox6 + 12) = 270540808;
		*(ref <Module>.?A0x0832d670.sbox6 + 16) = 270532608;
		*(ref <Module>.?A0x0832d670.sbox6 + 20) = 8;
		*(ref <Module>.?A0x0832d670.sbox6 + 24) = 270540808;
		*(ref <Module>.?A0x0832d670.sbox6 + 28) = 2097152;
		*(ref <Module>.?A0x0832d670.sbox6 + 32) = 268443648;
		*(ref <Module>.?A0x0832d670.sbox6 + 36) = 2105352;
		*(ref <Module>.?A0x0832d670.sbox6 + 40) = 2097152;
		*(ref <Module>.?A0x0832d670.sbox6 + 44) = 268435464;
		*(ref <Module>.?A0x0832d670.sbox6 + 48) = 2097160;
		*(ref <Module>.?A0x0832d670.sbox6 + 52) = 268443648;
		*(ref <Module>.?A0x0832d670.sbox6 + 56) = 268435456;
		*(ref <Module>.?A0x0832d670.sbox6 + 60) = 8200;
		*(ref <Module>.?A0x0832d670.sbox6 + 64) = 0;
		*(ref <Module>.?A0x0832d670.sbox6 + 68) = 2097160;
		*(ref <Module>.?A0x0832d670.sbox6 + 72) = 268443656;
		*(ref <Module>.?A0x0832d670.sbox6 + 76) = 8192;
		*(ref <Module>.?A0x0832d670.sbox6 + 80) = 2105344;
		*(ref <Module>.?A0x0832d670.sbox6 + 84) = 268443656;
		*(ref <Module>.?A0x0832d670.sbox6 + 88) = 8;
		*(ref <Module>.?A0x0832d670.sbox6 + 92) = 270532616;
		*(ref <Module>.?A0x0832d670.sbox6 + 96) = 270532616;
		*(ref <Module>.?A0x0832d670.sbox6 + 100) = 0;
		*(ref <Module>.?A0x0832d670.sbox6 + 104) = 2105352;
		*(ref <Module>.?A0x0832d670.sbox6 + 108) = 270540800;
		*(ref <Module>.?A0x0832d670.sbox6 + 112) = 8200;
		*(ref <Module>.?A0x0832d670.sbox6 + 116) = 2105344;
		*(ref <Module>.?A0x0832d670.sbox6 + 120) = 270540800;
		*(ref <Module>.?A0x0832d670.sbox6 + 124) = 268435456;
		*(ref <Module>.?A0x0832d670.sbox6 + 128) = 268443648;
		*(ref <Module>.?A0x0832d670.sbox6 + 132) = 8;
		*(ref <Module>.?A0x0832d670.sbox6 + 136) = 270532616;
		*(ref <Module>.?A0x0832d670.sbox6 + 140) = 2105344;
		*(ref <Module>.?A0x0832d670.sbox6 + 144) = 270540808;
		*(ref <Module>.?A0x0832d670.sbox6 + 148) = 2097152;
		*(ref <Module>.?A0x0832d670.sbox6 + 152) = 8200;
		*(ref <Module>.?A0x0832d670.sbox6 + 156) = 268435464;
		*(ref <Module>.?A0x0832d670.sbox6 + 160) = 2097152;
		*(ref <Module>.?A0x0832d670.sbox6 + 164) = 268443648;
		*(ref <Module>.?A0x0832d670.sbox6 + 168) = 268435456;
		*(ref <Module>.?A0x0832d670.sbox6 + 172) = 8200;
		*(ref <Module>.?A0x0832d670.sbox6 + 176) = 268435464;
		*(ref <Module>.?A0x0832d670.sbox6 + 180) = 270540808;
		*(ref <Module>.?A0x0832d670.sbox6 + 184) = 2105344;
		*(ref <Module>.?A0x0832d670.sbox6 + 188) = 270532608;
		*(ref <Module>.?A0x0832d670.sbox6 + 192) = 2105352;
		*(ref <Module>.?A0x0832d670.sbox6 + 196) = 270540800;
		*(ref <Module>.?A0x0832d670.sbox6 + 200) = 0;
		*(ref <Module>.?A0x0832d670.sbox6 + 204) = 270532616;
		*(ref <Module>.?A0x0832d670.sbox6 + 208) = 8;
		*(ref <Module>.?A0x0832d670.sbox6 + 212) = 8192;
		*(ref <Module>.?A0x0832d670.sbox6 + 216) = 270532608;
		*(ref <Module>.?A0x0832d670.sbox6 + 220) = 2105352;
		*(ref <Module>.?A0x0832d670.sbox6 + 224) = 8192;
		*(ref <Module>.?A0x0832d670.sbox6 + 228) = 2097160;
		*(ref <Module>.?A0x0832d670.sbox6 + 232) = 268443656;
		*(ref <Module>.?A0x0832d670.sbox6 + 236) = 0;
		*(ref <Module>.?A0x0832d670.sbox6 + 240) = 270540800;
		*(ref <Module>.?A0x0832d670.sbox6 + 244) = 268435456;
		*(ref <Module>.?A0x0832d670.sbox6 + 248) = 2097160;
		*(ref <Module>.?A0x0832d670.sbox6 + 252) = 268443656;
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00009DE4 File Offset: 0x000091E4
	internal unsafe static void ??__E?A0x0832d670@sbox7@@YMXXZ()
	{
		<Module>.?A0x0832d670.sbox7 = 1048576;
		*(ref <Module>.?A0x0832d670.sbox7 + 4) = 34603009;
		*(ref <Module>.?A0x0832d670.sbox7 + 8) = 33555457;
		*(ref <Module>.?A0x0832d670.sbox7 + 12) = 0;
		*(ref <Module>.?A0x0832d670.sbox7 + 16) = 1024;
		*(ref <Module>.?A0x0832d670.sbox7 + 20) = 33555457;
		*(ref <Module>.?A0x0832d670.sbox7 + 24) = 1049601;
		*(ref <Module>.?A0x0832d670.sbox7 + 28) = 34604032;
		*(ref <Module>.?A0x0832d670.sbox7 + 32) = 34604033;
		*(ref <Module>.?A0x0832d670.sbox7 + 36) = 1048576;
		*(ref <Module>.?A0x0832d670.sbox7 + 40) = 0;
		*(ref <Module>.?A0x0832d670.sbox7 + 44) = 33554433;
		*(ref <Module>.?A0x0832d670.sbox7 + 48) = 1;
		*(ref <Module>.?A0x0832d670.sbox7 + 52) = 33554432;
		*(ref <Module>.?A0x0832d670.sbox7 + 56) = 34603009;
		*(ref <Module>.?A0x0832d670.sbox7 + 60) = 1025;
		*(ref <Module>.?A0x0832d670.sbox7 + 64) = 33555456;
		*(ref <Module>.?A0x0832d670.sbox7 + 68) = 1049601;
		*(ref <Module>.?A0x0832d670.sbox7 + 72) = 1048577;
		*(ref <Module>.?A0x0832d670.sbox7 + 76) = 33555456;
		*(ref <Module>.?A0x0832d670.sbox7 + 80) = 33554433;
		*(ref <Module>.?A0x0832d670.sbox7 + 84) = 34603008;
		*(ref <Module>.?A0x0832d670.sbox7 + 88) = 34604032;
		*(ref <Module>.?A0x0832d670.sbox7 + 92) = 1048577;
		*(ref <Module>.?A0x0832d670.sbox7 + 96) = 34603008;
		*(ref <Module>.?A0x0832d670.sbox7 + 100) = 1024;
		*(ref <Module>.?A0x0832d670.sbox7 + 104) = 1025;
		*(ref <Module>.?A0x0832d670.sbox7 + 108) = 34604033;
		*(ref <Module>.?A0x0832d670.sbox7 + 112) = 1049600;
		*(ref <Module>.?A0x0832d670.sbox7 + 116) = 1;
		*(ref <Module>.?A0x0832d670.sbox7 + 120) = 33554432;
		*(ref <Module>.?A0x0832d670.sbox7 + 124) = 1049600;
		*(ref <Module>.?A0x0832d670.sbox7 + 128) = 33554432;
		*(ref <Module>.?A0x0832d670.sbox7 + 132) = 1049600;
		*(ref <Module>.?A0x0832d670.sbox7 + 136) = 1048576;
		*(ref <Module>.?A0x0832d670.sbox7 + 140) = 33555457;
		*(ref <Module>.?A0x0832d670.sbox7 + 144) = 33555457;
		*(ref <Module>.?A0x0832d670.sbox7 + 148) = 34603009;
		*(ref <Module>.?A0x0832d670.sbox7 + 152) = 34603009;
		*(ref <Module>.?A0x0832d670.sbox7 + 156) = 1;
		*(ref <Module>.?A0x0832d670.sbox7 + 160) = 1048577;
		*(ref <Module>.?A0x0832d670.sbox7 + 164) = 33554432;
		*(ref <Module>.?A0x0832d670.sbox7 + 168) = 33555456;
		*(ref <Module>.?A0x0832d670.sbox7 + 172) = 1048576;
		*(ref <Module>.?A0x0832d670.sbox7 + 176) = 34604032;
		*(ref <Module>.?A0x0832d670.sbox7 + 180) = 1025;
		*(ref <Module>.?A0x0832d670.sbox7 + 184) = 1049601;
		*(ref <Module>.?A0x0832d670.sbox7 + 188) = 34604032;
		*(ref <Module>.?A0x0832d670.sbox7 + 192) = 1025;
		*(ref <Module>.?A0x0832d670.sbox7 + 196) = 33554433;
		*(ref <Module>.?A0x0832d670.sbox7 + 200) = 34604033;
		*(ref <Module>.?A0x0832d670.sbox7 + 204) = 34603008;
		*(ref <Module>.?A0x0832d670.sbox7 + 208) = 1049600;
		*(ref <Module>.?A0x0832d670.sbox7 + 212) = 0;
		*(ref <Module>.?A0x0832d670.sbox7 + 216) = 1;
		*(ref <Module>.?A0x0832d670.sbox7 + 220) = 34604033;
		*(ref <Module>.?A0x0832d670.sbox7 + 224) = 0;
		*(ref <Module>.?A0x0832d670.sbox7 + 228) = 1049601;
		*(ref <Module>.?A0x0832d670.sbox7 + 232) = 34603008;
		*(ref <Module>.?A0x0832d670.sbox7 + 236) = 1024;
		*(ref <Module>.?A0x0832d670.sbox7 + 240) = 33554433;
		*(ref <Module>.?A0x0832d670.sbox7 + 244) = 33555456;
		*(ref <Module>.?A0x0832d670.sbox7 + 248) = 1024;
		*(ref <Module>.?A0x0832d670.sbox7 + 252) = 1048577;
	}

	// Token: 0x06000096 RID: 150 RVA: 0x0000A1AC File Offset: 0x000095AC
	internal unsafe static void ??__E?A0x0832d670@sbox8@@YMXXZ()
	{
		<Module>.?A0x0832d670.sbox8 = 134219808;
		*(ref <Module>.?A0x0832d670.sbox8 + 4) = 2048;
		*(ref <Module>.?A0x0832d670.sbox8 + 8) = 131072;
		*(ref <Module>.?A0x0832d670.sbox8 + 12) = 134350880;
		*(ref <Module>.?A0x0832d670.sbox8 + 16) = 134217728;
		*(ref <Module>.?A0x0832d670.sbox8 + 20) = 134219808;
		*(ref <Module>.?A0x0832d670.sbox8 + 24) = 32;
		*(ref <Module>.?A0x0832d670.sbox8 + 28) = 134217728;
		*(ref <Module>.?A0x0832d670.sbox8 + 32) = 131104;
		*(ref <Module>.?A0x0832d670.sbox8 + 36) = 134348800;
		*(ref <Module>.?A0x0832d670.sbox8 + 40) = 134350880;
		*(ref <Module>.?A0x0832d670.sbox8 + 44) = 133120;
		*(ref <Module>.?A0x0832d670.sbox8 + 48) = 134350848;
		*(ref <Module>.?A0x0832d670.sbox8 + 52) = 133152;
		*(ref <Module>.?A0x0832d670.sbox8 + 56) = 2048;
		*(ref <Module>.?A0x0832d670.sbox8 + 60) = 32;
		*(ref <Module>.?A0x0832d670.sbox8 + 64) = 134348800;
		*(ref <Module>.?A0x0832d670.sbox8 + 68) = 134217760;
		*(ref <Module>.?A0x0832d670.sbox8 + 72) = 134219776;
		*(ref <Module>.?A0x0832d670.sbox8 + 76) = 2080;
		*(ref <Module>.?A0x0832d670.sbox8 + 80) = 133120;
		*(ref <Module>.?A0x0832d670.sbox8 + 84) = 131104;
		*(ref <Module>.?A0x0832d670.sbox8 + 88) = 134348832;
		*(ref <Module>.?A0x0832d670.sbox8 + 92) = 134350848;
		*(ref <Module>.?A0x0832d670.sbox8 + 96) = 2080;
		*(ref <Module>.?A0x0832d670.sbox8 + 100) = 0;
		*(ref <Module>.?A0x0832d670.sbox8 + 104) = 0;
		*(ref <Module>.?A0x0832d670.sbox8 + 108) = 134348832;
		*(ref <Module>.?A0x0832d670.sbox8 + 112) = 134217760;
		*(ref <Module>.?A0x0832d670.sbox8 + 116) = 134219776;
		*(ref <Module>.?A0x0832d670.sbox8 + 120) = 133152;
		*(ref <Module>.?A0x0832d670.sbox8 + 124) = 131072;
		*(ref <Module>.?A0x0832d670.sbox8 + 128) = 133152;
		*(ref <Module>.?A0x0832d670.sbox8 + 132) = 131072;
		*(ref <Module>.?A0x0832d670.sbox8 + 136) = 134350848;
		*(ref <Module>.?A0x0832d670.sbox8 + 140) = 2048;
		*(ref <Module>.?A0x0832d670.sbox8 + 144) = 32;
		*(ref <Module>.?A0x0832d670.sbox8 + 148) = 134348832;
		*(ref <Module>.?A0x0832d670.sbox8 + 152) = 2048;
		*(ref <Module>.?A0x0832d670.sbox8 + 156) = 133152;
		*(ref <Module>.?A0x0832d670.sbox8 + 160) = 134219776;
		*(ref <Module>.?A0x0832d670.sbox8 + 164) = 32;
		*(ref <Module>.?A0x0832d670.sbox8 + 168) = 134217760;
		*(ref <Module>.?A0x0832d670.sbox8 + 172) = 134348800;
		*(ref <Module>.?A0x0832d670.sbox8 + 176) = 134348832;
		*(ref <Module>.?A0x0832d670.sbox8 + 180) = 134217728;
		*(ref <Module>.?A0x0832d670.sbox8 + 184) = 131072;
		*(ref <Module>.?A0x0832d670.sbox8 + 188) = 134219808;
		*(ref <Module>.?A0x0832d670.sbox8 + 192) = 0;
		*(ref <Module>.?A0x0832d670.sbox8 + 196) = 134350880;
		*(ref <Module>.?A0x0832d670.sbox8 + 200) = 131104;
		*(ref <Module>.?A0x0832d670.sbox8 + 204) = 134217760;
		*(ref <Module>.?A0x0832d670.sbox8 + 208) = 134348800;
		*(ref <Module>.?A0x0832d670.sbox8 + 212) = 134219776;
		*(ref <Module>.?A0x0832d670.sbox8 + 216) = 134219808;
		*(ref <Module>.?A0x0832d670.sbox8 + 220) = 0;
		*(ref <Module>.?A0x0832d670.sbox8 + 224) = 134350880;
		*(ref <Module>.?A0x0832d670.sbox8 + 228) = 133120;
		*(ref <Module>.?A0x0832d670.sbox8 + 232) = 133120;
		*(ref <Module>.?A0x0832d670.sbox8 + 236) = 2080;
		*(ref <Module>.?A0x0832d670.sbox8 + 240) = 2080;
		*(ref <Module>.?A0x0832d670.sbox8 + 244) = 131104;
		*(ref <Module>.?A0x0832d670.sbox8 + 248) = 134217728;
		*(ref <Module>.?A0x0832d670.sbox8 + 252) = 134350848;
	}

	// Token: 0x06000097 RID: 151 RVA: 0x0000A578 File Offset: 0x00009978
	internal unsafe static void ??__Eleftkey_swap@@YMXXZ()
	{
		<Module>.leftkey_swap = 0;
		*(ref <Module>.leftkey_swap + 4) = 1;
		*(ref <Module>.leftkey_swap + 8) = 256;
		*(ref <Module>.leftkey_swap + 12) = 257;
		*(ref <Module>.leftkey_swap + 16) = 65536;
		*(ref <Module>.leftkey_swap + 20) = 65537;
		*(ref <Module>.leftkey_swap + 24) = 65792;
		*(ref <Module>.leftkey_swap + 28) = 65793;
		*(ref <Module>.leftkey_swap + 32) = 16777216;
		*(ref <Module>.leftkey_swap + 36) = 16777217;
		*(ref <Module>.leftkey_swap + 40) = 16777472;
		*(ref <Module>.leftkey_swap + 44) = 16777473;
		*(ref <Module>.leftkey_swap + 48) = 16842752;
		*(ref <Module>.leftkey_swap + 52) = 16842753;
		*(ref <Module>.leftkey_swap + 56) = 16843008;
		*(ref <Module>.leftkey_swap + 60) = 16843009;
	}

	// Token: 0x06000098 RID: 152 RVA: 0x0000A658 File Offset: 0x00009A58
	internal unsafe static void ??__Erightkey_swap@@YMXXZ()
	{
		<Module>.rightkey_swap = 0;
		*(ref <Module>.rightkey_swap + 4) = 16777216;
		*(ref <Module>.rightkey_swap + 8) = 65536;
		*(ref <Module>.rightkey_swap + 12) = 16842752;
		*(ref <Module>.rightkey_swap + 16) = 256;
		*(ref <Module>.rightkey_swap + 20) = 16777472;
		*(ref <Module>.rightkey_swap + 24) = 65792;
		*(ref <Module>.rightkey_swap + 28) = 16843008;
		*(ref <Module>.rightkey_swap + 32) = 1;
		*(ref <Module>.rightkey_swap + 36) = 16777217;
		*(ref <Module>.rightkey_swap + 40) = 65537;
		*(ref <Module>.rightkey_swap + 44) = 16842753;
		*(ref <Module>.rightkey_swap + 48) = 257;
		*(ref <Module>.rightkey_swap + 52) = 16777473;
		*(ref <Module>.rightkey_swap + 56) = 65793;
		*(ref <Module>.rightkey_swap + 60) = 16843009;
	}

	// Token: 0x06000099 RID: 153 RVA: 0x0000A738 File Offset: 0x00009B38
	internal unsafe static void ??__E?A0x0832d670@encrypt_rotate_tab@@YMXXZ()
	{
		<Module>.?A0x0832d670.encrypt_rotate_tab = 1;
		*(ref <Module>.?A0x0832d670.encrypt_rotate_tab + 1) = 1;
		*(ref <Module>.?A0x0832d670.encrypt_rotate_tab + 2) = 2;
		*(ref <Module>.?A0x0832d670.encrypt_rotate_tab + 3) = 2;
		*(ref <Module>.?A0x0832d670.encrypt_rotate_tab + 4) = 2;
		*(ref <Module>.?A0x0832d670.encrypt_rotate_tab + 5) = 2;
		*(ref <Module>.?A0x0832d670.encrypt_rotate_tab + 6) = 2;
		*(ref <Module>.?A0x0832d670.encrypt_rotate_tab + 7) = 2;
		*(ref <Module>.?A0x0832d670.encrypt_rotate_tab + 8) = 1;
		*(ref <Module>.?A0x0832d670.encrypt_rotate_tab + 9) = 2;
		*(ref <Module>.?A0x0832d670.encrypt_rotate_tab + 10) = 2;
		*(ref <Module>.?A0x0832d670.encrypt_rotate_tab + 11) = 2;
		*(ref <Module>.?A0x0832d670.encrypt_rotate_tab + 12) = 2;
		*(ref <Module>.?A0x0832d670.encrypt_rotate_tab + 13) = 2;
		*(ref <Module>.?A0x0832d670.encrypt_rotate_tab + 14) = 2;
		*(ref <Module>.?A0x0832d670.encrypt_rotate_tab + 15) = 1;
	}

	// Token: 0x0600009A RID: 154 RVA: 0x0000A7DC File Offset: 0x00009BDC
	internal unsafe static void ??__E?A0x0832d670@weak_keys@@YMXXZ()
	{
		<Module>.?A0x0832d670.weak_keys = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 1) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 2) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 3) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 4) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 5) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 6) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 7) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 8) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 9) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 10) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 11) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 12) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 13) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 14) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 15) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 16) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 17) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 18) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 19) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 20) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 21) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 22) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 23) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 24) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 25) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 26) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 27) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 28) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 29) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 30) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 31) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 32) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 33) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 34) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 35) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 36) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 37) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 38) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 39) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 40) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 41) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 42) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 43) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 44) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 45) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 46) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 47) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 48) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 49) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 50) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 51) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 52) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 53) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 54) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 55) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 56) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 57) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 58) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 59) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 60) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 61) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 62) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 63) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 64) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 65) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 66) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 67) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 68) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 69) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 70) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 71) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 72) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 73) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 74) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 75) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 76) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 77) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 78) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 79) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 80) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 81) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 82) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 83) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 84) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 85) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 86) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 87) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 88) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 89) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 90) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 91) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 92) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 93) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 94) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 95) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 96) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 97) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 98) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 99) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 100) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 101) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 102) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 103) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 104) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 105) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 106) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 107) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 108) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 109) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 110) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 111) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 112) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 113) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 114) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 115) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 116) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 117) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 118) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 119) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 120) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 121) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 122) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 123) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 124) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 125) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 126) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 127) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 128) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 129) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 130) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 131) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 132) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 133) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 134) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 135) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 136) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 137) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 138) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 139) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 140) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 141) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 142) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 143) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 144) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 145) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 146) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 147) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 148) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 149) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 150) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 151) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 152) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 153) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 154) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 155) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 156) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 157) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 158) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 159) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 160) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 161) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 162) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 163) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 164) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 165) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 166) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 167) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 168) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 169) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 170) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 171) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 172) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 173) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 174) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 175) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 176) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 177) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 178) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 179) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 180) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 181) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 182) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 183) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 184) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 185) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 186) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 187) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 188) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 189) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 190) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 191) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 192) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 193) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 194) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 195) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 196) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 197) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 198) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 199) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 200) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 201) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 202) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 203) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 204) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 205) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 206) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 207) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 208) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 209) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 210) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 211) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 212) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 213) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 214) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 215) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 216) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 217) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 218) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 219) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 220) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 221) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 222) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 223) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 224) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 225) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 226) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 227) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 228) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 229) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 230) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 231) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 232) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 233) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 234) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 235) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 236) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 237) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 238) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 239) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 240) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 241) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 242) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 243) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 244) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 245) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 246) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 247) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 248) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 249) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 250) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 251) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 252) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 253) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 254) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 255) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 256) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 257) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 258) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 259) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 260) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 261) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 262) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 263) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 264) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 265) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 266) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 267) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 268) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 269) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 270) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 271) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 272) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 273) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 274) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 275) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 276) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 277) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 278) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 279) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 280) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 281) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 282) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 283) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 284) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 285) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 286) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 287) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 288) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 289) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 290) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 291) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 292) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 293) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 294) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 295) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 296) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 297) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 298) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 299) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 300) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 301) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 302) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 303) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 304) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 305) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 306) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 307) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 308) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 309) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 310) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 311) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 312) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 313) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 314) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 315) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 316) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 317) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 318) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 319) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 320) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 321) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 322) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 323) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 324) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 325) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 326) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 327) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 328) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 329) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 330) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 331) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 332) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 333) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 334) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 335) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 336) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 337) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 338) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 339) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 340) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 341) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 342) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 343) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 344) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 345) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 346) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 347) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 348) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 349) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 350) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 351) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 352) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 353) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 354) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 355) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 356) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 357) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 358) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 359) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 360) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 361) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 362) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 363) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 364) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 365) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 366) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 367) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 368) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 369) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 370) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 371) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 372) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 373) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 374) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 375) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 376) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 377) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 378) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 379) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 380) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 381) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 382) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 383) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 384) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 385) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 386) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 387) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 388) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 389) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 390) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 391) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 392) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 393) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 394) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 395) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 396) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 397) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 398) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 399) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 400) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 401) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 402) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 403) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 404) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 405) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 406) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 407) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 408) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 409) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 410) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 411) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 412) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 413) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 414) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 415) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 416) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 417) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 418) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 419) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 420) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 421) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 422) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 423) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 424) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 425) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 426) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 427) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 428) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 429) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 430) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 431) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 432) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 433) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 434) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 435) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 436) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 437) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 438) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 439) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 440) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 441) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 442) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 443) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 444) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 445) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 446) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 447) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 448) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 449) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 450) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 451) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 452) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 453) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 454) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 455) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 456) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 457) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 458) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 459) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 460) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 461) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 462) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 463) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 464) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 465) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 466) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 467) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 468) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 469) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 470) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 471) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 472) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 473) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 474) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 475) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 476) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 477) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 478) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 479) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 480) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 481) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 482) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 483) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 484) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 485) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 486) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 487) = 0;
		*(ref <Module>.?A0x0832d670.weak_keys + 488) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 489) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 490) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 491) = 30;
		*(ref <Module>.?A0x0832d670.weak_keys + 492) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 493) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 494) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 495) = 14;
		*(ref <Module>.?A0x0832d670.weak_keys + 496) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 497) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 498) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 499) = 224;
		*(ref <Module>.?A0x0832d670.weak_keys + 500) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 501) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 502) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 503) = 240;
		*(ref <Module>.?A0x0832d670.weak_keys + 504) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 505) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 506) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 507) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 508) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 509) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 510) = 254;
		*(ref <Module>.?A0x0832d670.weak_keys + 511) = 254;
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00006AD8 File Offset: 0x00005ED8
	internal unsafe static void des_key_schedule(byte* rawkey, uint* subkey)
	{
		uint num = (uint)((int)(*(byte*)rawkey) << 24 | (int)(*(byte*)(rawkey + 1 / sizeof(byte))) << 16 | (int)(*(byte*)(rawkey + 2 / sizeof(byte))) << 8 | (int)(*(byte*)(rawkey + 3 / sizeof(byte))));
		uint num2 = (uint)((int)(*(byte*)(rawkey + 4 / sizeof(byte))) << 24 | (int)(*(byte*)(rawkey + 5 / sizeof(byte))) << 16 | (int)(*(byte*)(rawkey + 6 / sizeof(byte))) << 8 | (int)(*(byte*)(rawkey + 7 / sizeof(byte))));
		uint num3 = (num2 >> 4 ^ num) & 252645135u;
		num ^= num3;
		num2 ^= num3 << 4;
		num3 = ((num2 ^ num) & 269488144u);
		num ^= num3;
		num2 ^= num3;
		num = (uint)(*(ref <Module>.leftkey_swap + (num & 15u) * 4u) << 3 | *(ref <Module>.leftkey_swap + (num >> 8 & 15u) * 4u) << 2 | *(ref <Module>.leftkey_swap + (num >> 16 & 15u) * 4u) << 1 | *(ref <Module>.leftkey_swap + (num >> 24 & 15u) * 4u) | *(ref <Module>.leftkey_swap + (num >> 5 & 15u) * 4u) << 7 | *(ref <Module>.leftkey_swap + (num >> 13 & 15u) * 4u) << 6 | *(ref <Module>.leftkey_swap + (num >> 21 & 15u) * 4u) << 5 | *(ref <Module>.leftkey_swap + (num >> 29 & 15u) * 4u) << 4);
		num &= 268435455u;
		num2 = (uint)(*(ref <Module>.rightkey_swap + (num2 >> 1 & 15u) * 4u) << 3 | *(ref <Module>.rightkey_swap + (num2 >> 9 & 15u) * 4u) << 2 | *(ref <Module>.rightkey_swap + (num2 >> 17 & 15u) * 4u) << 1 | *(ref <Module>.rightkey_swap + (num2 >> 25 & 15u) * 4u) | *(ref <Module>.rightkey_swap + (num2 >> 4 & 15u) * 4u) << 7 | *(ref <Module>.rightkey_swap + (num2 >> 12 & 15u) * 4u) << 6 | *(ref <Module>.rightkey_swap + (num2 >> 20 & 15u) * 4u) << 5 | *(ref <Module>.rightkey_swap + (num2 >> 28 & 15u) * 4u) << 4);
		num2 &= 268435455u;
		for (int i = 0; i < 16; i++)
		{
			num = ((num << (int)(*(ref <Module>.?A0x0832d670.encrypt_rotate_tab + i)) | num >> (int)(28 - *(ref <Module>.?A0x0832d670.encrypt_rotate_tab + i))) & 268435455u);
			num2 = ((num2 << (int)(*(ref <Module>.?A0x0832d670.encrypt_rotate_tab + i)) | num2 >> (int)(28 - *(ref <Module>.?A0x0832d670.encrypt_rotate_tab + i))) & 268435455u);
			*subkey = ((num << 4 & 603979776u) | (num << 28 & 268435456u) | (num << 14 & 134217728u) | (num << 18 & 34078720u) | (num << 6 & 16777216u) | (num << 9 & 2097152u) | (num >> 1 & 1048576u) | (num << 10 & 262144u) | (num << 2 & 131072u) | (num >> 10 & 65536u) | (num2 >> 13 & 8192u) | (num2 >> 4 & 4096u) | (num2 << 6 & 2048u) | (num2 >> 1 & 1024u) | (num2 >> 14 & 512u) | (num2 & 256u) | (num2 >> 5 & 32u) | (num2 >> 10 & 16u) | (num2 >> 3 & 8u) | (num2 >> 18 & 4u) | (num2 >> 26 & 2u) | (num2 >> 24 & 1u));
			subkey++;
			*subkey = ((num << 15 & 536870912u) | (num << 17 & 268435456u) | (num << 10 & 134217728u) | (num << 22 & 67108864u) | (num >> 2 & 33554432u) | (num << 1 & 16777216u) | (num << 16 & 2097152u) | (num << 11 & 1048576u) | (num << 3 & 524288u) | (num >> 6 & 262144u) | (num << 15 & 131072u) | (num >> 4 & 65536u) | (num2 >> 2 & 8192u) | (num2 << 8 & 4096u) | (num2 >> 14 & 2056u) | (num2 >> 9 & 1024u) | (num2 & 512u) | (num2 << 7 & 256u) | (num2 >> 7 & 32u) | (num2 >> 3 & 17u) | (num2 << 2 & 4u) | (num2 >> 21 & 2u));
			subkey++;
		}
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00007114 File Offset: 0x00006514
	internal unsafe static int des_setkey(_des_ctx* ctx, byte* key)
	{
		int result;
		if (<Module>.?A0x0832d670.selftest_failed != null)
		{
			result = -1;
		}
		else
		{
			<Module>.?A0x0832d670.des_key_schedule(key, (uint*)ctx);
			for (int i = 0; i < 32; i += 2)
			{
				*(int*)(ctx + 128 / sizeof(_des_ctx) + i * 4 / sizeof(_des_ctx)) = *(int*)(ctx + (30 - i) * 4 / sizeof(_des_ctx));
				*(int*)(ctx + 128 / sizeof(_des_ctx) + (i + 1) * 4 / sizeof(_des_ctx)) = *(int*)(ctx + (31 - i) * 4 / sizeof(_des_ctx));
			}
			result = 0;
		}
		return result;
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00005E3C File Offset: 0x0000523C
	internal unsafe static int des_ecb_crypt(_des_ctx* ctx, byte* from, byte* to, int mode)
	{
		uint* ptr = (uint*)((mode == 0) ? ctx : (ctx + 128 / sizeof(_des_ctx)));
		uint num = (uint)((int)(*(byte*)from) << 24 | (int)(*(byte*)(from + 1 / sizeof(byte))) << 16 | (int)(*(byte*)(from + 2 / sizeof(byte))) << 8 | (int)(*(byte*)(from + 3 / sizeof(byte))));
		uint num2 = (uint)((int)(*(byte*)(from + 4 / sizeof(byte))) << 24 | (int)(*(byte*)(from + 5 / sizeof(byte))) << 16 | (int)(*(byte*)(from + 6 / sizeof(byte))) << 8 | (int)(*(byte*)(from + 7 / sizeof(byte))));
		uint num3 = (num >> 4 ^ num2) & 252645135u;
		num2 ^= num3;
		num ^= num3 << 4;
		num3 = ((num >> 16 ^ num2) & 65535u);
		num2 ^= num3;
		num ^= num3 << 16;
		num3 = ((num2 >> 2 ^ num) & 858993459u);
		num ^= num3;
		num2 ^= num3 << 2;
		num3 = ((num2 >> 8 ^ num) & 16711935u);
		num ^= num3;
		num2 ^= num3 << 8;
		num3 = ((num >> 1 ^ num2) & 1431655765u);
		num2 ^= num3;
		num ^= num3 << 1;
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 1 ^ num) & 1431655765u);
		num ^= num3;
		num2 ^= num3 << 1;
		num3 = ((num >> 8 ^ num2) & 16711935u);
		num2 ^= num3;
		num ^= num3 << 8;
		num3 = ((num >> 2 ^ num2) & 858993459u);
		num2 ^= num3;
		num ^= num3 << 2;
		num3 = ((num2 >> 16 ^ num) & 65535u);
		num ^= num3;
		num2 ^= num3 << 16;
		num3 = ((num2 >> 4 ^ num) & 252645135u);
		num ^= num3;
		num2 ^= num3 << 4;
		*to = (byte)(num2 >> 24 & 255u);
		to[1] = (byte)(num2 >> 16 & 255u);
		to[2] = (byte)(num2 >> 8 & 255u);
		to[3] = (byte)(num2 & 255u);
		to[4] = (byte)(num >> 24 & 255u);
		to[5] = (byte)(num >> 16 & 255u);
		to[6] = (byte)(num >> 8 & 255u);
		to[7] = (byte)(num & 255u);
		return 0;
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00007024 File Offset: 0x00006424
	internal unsafe static int tripledes_set2keys(_tripledes_ctx* ctx, byte* key1, byte* key2)
	{
		<Module>.?A0x0832d670.des_key_schedule(key1, (uint*)ctx);
		<Module>.?A0x0832d670.des_key_schedule(key2, (uint*)(ctx + 512 / sizeof(_tripledes_ctx)));
		for (int i = 0; i < 32; i += 2)
		{
			*(int*)(ctx + 384 / sizeof(_tripledes_ctx) + i * 4 / sizeof(_tripledes_ctx)) = *(int*)(ctx + (30 - i) * 4 / sizeof(_tripledes_ctx));
			*(int*)(ctx + 384 / sizeof(_tripledes_ctx) + (i + 1) * 4 / sizeof(_tripledes_ctx)) = *(int*)(ctx + (31 - i) * 4 / sizeof(_tripledes_ctx));
			*(int*)(ctx + (i + 32) * 4 / sizeof(_tripledes_ctx)) = *(int*)(ctx + 384 / sizeof(_tripledes_ctx) + (62 - i) * 4 / sizeof(_tripledes_ctx));
			*(int*)(ctx + (i + 33) * 4 / sizeof(_tripledes_ctx)) = *(int*)(ctx + 384 / sizeof(_tripledes_ctx) + (63 - i) * 4 / sizeof(_tripledes_ctx));
			*(int*)(ctx + (i + 64) * 4 / sizeof(_tripledes_ctx)) = *(int*)(ctx + i * 4 / sizeof(_tripledes_ctx));
			*(int*)(ctx + (i + 65) * 4 / sizeof(_tripledes_ctx)) = *(int*)(ctx + (i + 1) * 4 / sizeof(_tripledes_ctx));
			*(int*)(ctx + 384 / sizeof(_tripledes_ctx) + (i + 64) * 4 / sizeof(_tripledes_ctx)) = *(int*)(ctx + 384 / sizeof(_tripledes_ctx) + i * 4 / sizeof(_tripledes_ctx));
			*(int*)(ctx + 384 / sizeof(_tripledes_ctx) + (i + 65) * 4 / sizeof(_tripledes_ctx)) = *(int*)(ctx + 384 / sizeof(_tripledes_ctx) + (i + 1) * 4 / sizeof(_tripledes_ctx));
		}
		return 0;
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00006F50 File Offset: 0x00006350
	internal unsafe static int tripledes_set3keys(_tripledes_ctx* ctx, byte* key1, byte* key2, byte* key3)
	{
		<Module>.?A0x0832d670.des_key_schedule(key1, (uint*)ctx);
		<Module>.?A0x0832d670.des_key_schedule(key2, (uint*)(ctx + 512 / sizeof(_tripledes_ctx)));
		<Module>.?A0x0832d670.des_key_schedule(key3, (uint*)(ctx + 256 / sizeof(_tripledes_ctx)));
		for (int i = 0; i < 32; i += 2)
		{
			*(int*)(ctx + 384 / sizeof(_tripledes_ctx) + i * 4 / sizeof(_tripledes_ctx)) = *(int*)(ctx + (94 - i) * 4 / sizeof(_tripledes_ctx));
			*(int*)(ctx + 384 / sizeof(_tripledes_ctx) + (i + 1) * 4 / sizeof(_tripledes_ctx)) = *(int*)(ctx + (95 - i) * 4 / sizeof(_tripledes_ctx));
			*(int*)(ctx + (i + 32) * 4 / sizeof(_tripledes_ctx)) = *(int*)(ctx + 384 / sizeof(_tripledes_ctx) + (62 - i) * 4 / sizeof(_tripledes_ctx));
			*(int*)(ctx + (i + 33) * 4 / sizeof(_tripledes_ctx)) = *(int*)(ctx + 384 / sizeof(_tripledes_ctx) + (63 - i) * 4 / sizeof(_tripledes_ctx));
			*(int*)(ctx + 384 / sizeof(_tripledes_ctx) + (i + 64) * 4 / sizeof(_tripledes_ctx)) = *(int*)(ctx + (30 - i) * 4 / sizeof(_tripledes_ctx));
			*(int*)(ctx + 384 / sizeof(_tripledes_ctx) + (i + 65) * 4 / sizeof(_tripledes_ctx)) = *(int*)(ctx + (31 - i) * 4 / sizeof(_tripledes_ctx));
		}
		return 0;
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00003BA0 File Offset: 0x00002FA0
	internal unsafe static int tripledes_ecb_crypt(_tripledes_ctx* ctx, byte* from, byte* to, int mode)
	{
		uint* ptr = (uint*)((mode == 0) ? ctx : (ctx + 384 / sizeof(_tripledes_ctx)));
		uint num = (uint)((int)(*(byte*)from) << 24 | (int)(*(byte*)(from + 1 / sizeof(byte))) << 16 | (int)(*(byte*)(from + 2 / sizeof(byte))) << 8 | (int)(*(byte*)(from + 3 / sizeof(byte))));
		uint num2 = (uint)((int)(*(byte*)(from + 4 / sizeof(byte))) << 24 | (int)(*(byte*)(from + 5 / sizeof(byte))) << 16 | (int)(*(byte*)(from + 6 / sizeof(byte))) << 8 | (int)(*(byte*)(from + 7 / sizeof(byte))));
		uint num3 = (num >> 4 ^ num2) & 252645135u;
		num2 ^= num3;
		num ^= num3 << 4;
		num3 = ((num >> 16 ^ num2) & 65535u);
		num2 ^= num3;
		num ^= num3 << 16;
		num3 = ((num2 >> 2 ^ num) & 858993459u);
		num ^= num3;
		num2 ^= num3 << 2;
		num3 = ((num2 >> 8 ^ num) & 16711935u);
		num ^= num3;
		num2 ^= num3 << 8;
		num3 = ((num >> 1 ^ num2) & 1431655765u);
		num2 ^= num3;
		num ^= num3 << 1;
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 << 1 | num2 >> 31) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 3 | num2 << 29) ^ *ptr);
		ptr++;
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num << 1 | num >> 31) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox8 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox6 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox4 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox2 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num >> 3 | num << 29) ^ *ptr);
		ptr++;
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox7 + (num3 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox5 + (num3 >> 8 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox3 + (num3 >> 16 & 63u) * 4u));
		num2 ^= (uint)(*(ref <Module>.?A0x0832d670.sbox1 + (num3 >> 24 & 63u) * 4u));
		num3 = ((num2 >> 1 ^ num) & 1431655765u);
		num ^= num3;
		num2 ^= num3 << 1;
		num3 = ((num >> 8 ^ num2) & 16711935u);
		num2 ^= num3;
		num ^= num3 << 8;
		num3 = ((num >> 2 ^ num2) & 858993459u);
		num2 ^= num3;
		num ^= num3 << 2;
		num3 = ((num2 >> 16 ^ num) & 65535u);
		num ^= num3;
		num2 ^= num3 << 16;
		num3 = ((num2 >> 4 ^ num) & 252645135u);
		num ^= num3;
		num2 ^= num3 << 4;
		*to = (byte)(num2 >> 24 & 255u);
		to[1] = (byte)(num2 >> 16 & 255u);
		to[2] = (byte)(num2 >> 8 & 255u);
		to[3] = (byte)(num2 & 255u);
		to[4] = (byte)(num >> 24 & 255u);
		to[5] = (byte)(num >> 16 & 255u);
		to[6] = (byte)(num >> 8 & 255u);
		to[7] = (byte)(num & 255u);
		return 0;
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00006EE4 File Offset: 0x000062E4
	internal unsafe static int is_weak_key(byte* key)
	{
		$ArrayType$$$BY07E $ArrayType$$$BY07E;
		for (int i = 0; i < 8; i++)
		{
			*(ref $ArrayType$$$BY07E + i) = (*(byte*)(key + i / sizeof(byte)) & 254);
		}
		int j = 0;
		int num = 63;
		while (j <= num)
		{
			int num2 = (j + num) / 2;
			int num3 = <Module>.working_memcmp((sbyte*)(&$ArrayType$$$BY07E), ref <Module>.?A0x0832d670.weak_keys + num2 * 8, 8u);
			if (num3 == 0)
			{
				return -1;
			}
			if (num3 > 0)
			{
				j = num2 + 1;
			}
			else
			{
				num = num2 - 1;
			}
		}
		return 0;
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x000071C8 File Offset: 0x000065C8
	internal unsafe static sbyte* selftest()
	{
		sbyte* result;
		if (false)
		{
			result = (sbyte*)(&<Module>.?A0x0832d670.unnamed-global-0);
		}
		else
		{
			$ArrayType$$$BY07E $ArrayType$$$BY07E = 85;
			*(ref $ArrayType$$$BY07E + 1) = 85;
			*(ref $ArrayType$$$BY07E + 2) = 85;
			*(ref $ArrayType$$$BY07E + 3) = 85;
			*(ref $ArrayType$$$BY07E + 4) = 85;
			*(ref $ArrayType$$$BY07E + 5) = 85;
			*(ref $ArrayType$$$BY07E + 6) = 85;
			*(ref $ArrayType$$$BY07E + 7) = 85;
			$ArrayType$$$BY07E $ArrayType$$$BY07E2 = 255;
			*(ref $ArrayType$$$BY07E2 + 1) = byte.MaxValue;
			*(ref $ArrayType$$$BY07E2 + 2) = byte.MaxValue;
			*(ref $ArrayType$$$BY07E2 + 3) = byte.MaxValue;
			*(ref $ArrayType$$$BY07E2 + 4) = byte.MaxValue;
			*(ref $ArrayType$$$BY07E2 + 5) = byte.MaxValue;
			*(ref $ArrayType$$$BY07E2 + 6) = byte.MaxValue;
			*(ref $ArrayType$$$BY07E2 + 7) = byte.MaxValue;
			$ArrayType$$$BY07E $ArrayType$$$BY07E3 = 36;
			*(ref $ArrayType$$$BY07E3 + 1) = 110;
			*(ref $ArrayType$$$BY07E3 + 2) = 157;
			*(ref $ArrayType$$$BY07E3 + 3) = 185;
			*(ref $ArrayType$$$BY07E3 + 4) = 197;
			*(ref $ArrayType$$$BY07E3 + 5) = 80;
			*(ref $ArrayType$$$BY07E3 + 6) = 56;
			*(ref $ArrayType$$$BY07E3 + 7) = 26;
			$ArrayType$$$BY07E $ArrayType$$$BY07E6;
			for (int i = 0; i < 64; i++)
			{
				$ArrayType$$$BY00U_des_ctx@@ $ArrayType$$$BY00U_des_ctx@@;
				<Module>.des_setkey((_des_ctx*)(&$ArrayType$$$BY00U_des_ctx@@), (byte*)(&$ArrayType$$$BY07E));
				$ArrayType$$$BY07E $ArrayType$$$BY07E4;
				<Module>.des_ecb_crypt((_des_ctx*)(&$ArrayType$$$BY00U_des_ctx@@), (byte*)(&$ArrayType$$$BY07E2), (byte*)(&$ArrayType$$$BY07E4), 0);
				$ArrayType$$$BY07E $ArrayType$$$BY07E5;
				<Module>.des_ecb_crypt((_des_ctx*)(&$ArrayType$$$BY00U_des_ctx@@), (byte*)(&$ArrayType$$$BY07E4), (byte*)(&$ArrayType$$$BY07E5), 0);
				<Module>.des_setkey((_des_ctx*)(&$ArrayType$$$BY00U_des_ctx@@), (byte*)(&$ArrayType$$$BY07E5));
				<Module>.des_ecb_crypt((_des_ctx*)(&$ArrayType$$$BY00U_des_ctx@@), (byte*)(&$ArrayType$$$BY07E4), (byte*)(&$ArrayType$$$BY07E6), 1);
				<Module>.memcpy((void*)(&$ArrayType$$$BY07E), (void*)(&$ArrayType$$$BY07E6), 8u);
				<Module>.memcpy((void*)(&$ArrayType$$$BY07E2), (void*)(&$ArrayType$$$BY07E4), 8u);
			}
			if (<Module>.memcmp((void*)(&$ArrayType$$$BY07E6), (void*)(&$ArrayType$$$BY07E3), 8u) != null)
			{
				result = (sbyte*)(&<Module>.?A0x0832d670.unnamed-global-1);
			}
			else
			{
				$ArrayType$$$BY07E $ArrayType$$$BY07E7 = 254;
				*(ref $ArrayType$$$BY07E7 + 1) = 220;
				*(ref $ArrayType$$$BY07E7 + 2) = 186;
				*(ref $ArrayType$$$BY07E7 + 3) = 152;
				*(ref $ArrayType$$$BY07E7 + 4) = 118;
				*(ref $ArrayType$$$BY07E7 + 5) = 84;
				*(ref $ArrayType$$$BY07E7 + 6) = 50;
				*(ref $ArrayType$$$BY07E7 + 7) = 16;
				$ArrayType$$$BY07E $ArrayType$$$BY07E8 = 18;
				*(ref $ArrayType$$$BY07E8 + 1) = 52;
				*(ref $ArrayType$$$BY07E8 + 2) = 86;
				*(ref $ArrayType$$$BY07E8 + 3) = 120;
				*(ref $ArrayType$$$BY07E8 + 4) = 154;
				*(ref $ArrayType$$$BY07E8 + 5) = 188;
				*(ref $ArrayType$$$BY07E8 + 6) = 222;
				*(ref $ArrayType$$$BY07E8 + 7) = 240;
				$ArrayType$$$BY07E $ArrayType$$$BY07E9 = 17;
				*(ref $ArrayType$$$BY07E9 + 1) = 34;
				*(ref $ArrayType$$$BY07E9 + 2) = 51;
				*(ref $ArrayType$$$BY07E9 + 3) = 68;
				*(ref $ArrayType$$$BY07E9 + 4) = byte.MaxValue;
				*(ref $ArrayType$$$BY07E9 + 5) = 170;
				*(ref $ArrayType$$$BY07E9 + 6) = 204;
				*(ref $ArrayType$$$BY07E9 + 7) = 221;
				$ArrayType$$$BY07E $ArrayType$$$BY07E10 = 123;
				*(ref $ArrayType$$$BY07E10 + 1) = 56;
				*(ref $ArrayType$$$BY07E10 + 2) = 59;
				*(ref $ArrayType$$$BY07E10 + 3) = 35;
				*(ref $ArrayType$$$BY07E10 + 4) = 162;
				*(ref $ArrayType$$$BY07E10 + 5) = 125;
				*(ref $ArrayType$$$BY07E10 + 6) = 38;
				*(ref $ArrayType$$$BY07E10 + 7) = 211;
				for (int j = 0; j < 16; j++)
				{
					$ArrayType$$$BY00U_tripledes_ctx@@ $ArrayType$$$BY00U_tripledes_ctx@@;
					<Module>.?A0x0832d670.tripledes_set2keys((_tripledes_ctx*)(&$ArrayType$$$BY00U_tripledes_ctx@@), (byte*)(&$ArrayType$$$BY07E8), (byte*)(&$ArrayType$$$BY07E9));
					<Module>.?A0x0832d670.tripledes_ecb_crypt((_tripledes_ctx*)(&$ArrayType$$$BY00U_tripledes_ctx@@), (byte*)(&$ArrayType$$$BY07E7), (byte*)(&$ArrayType$$$BY07E8), 0);
					<Module>.?A0x0832d670.tripledes_ecb_crypt((_tripledes_ctx*)(&$ArrayType$$$BY00U_tripledes_ctx@@), (byte*)(&$ArrayType$$$BY07E7), (byte*)(&$ArrayType$$$BY07E9), 1);
					<Module>.?A0x0832d670.tripledes_set3keys((_tripledes_ctx*)(&$ArrayType$$$BY00U_tripledes_ctx@@), (byte*)(&$ArrayType$$$BY07E8), (byte*)(&$ArrayType$$$BY07E7), (byte*)(&$ArrayType$$$BY07E9));
					<Module>.?A0x0832d670.tripledes_ecb_crypt((_tripledes_ctx*)(&$ArrayType$$$BY00U_tripledes_ctx@@), (byte*)(&$ArrayType$$$BY07E7), (byte*)(&$ArrayType$$$BY07E7), 0);
				}
				if (<Module>.memcmp((void*)(&$ArrayType$$$BY07E7), (void*)(&$ArrayType$$$BY07E10), 8u) != null)
				{
					result = (sbyte*)(&<Module>.?A0x0832d670.unnamed-global-2);
				}
				else
				{
					for (int k = 0; k < 64; k++)
					{
						if (<Module>.?A0x0832d670.is_weak_key(ref <Module>.?A0x0832d670.weak_keys + k * 8) == 0)
						{
							return (sbyte*)(&<Module>.?A0x0832d670.unnamed-global-3);
						}
					}
					result = null;
				}
			}
		}
		return result;
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00007174 File Offset: 0x00006574
	internal unsafe static int do_tripledes_setkey(_tripledes_ctx* ctx, byte* key, uint keylen)
	{
		int result;
		if (<Module>.?A0x0832d670.selftest_failed != null)
		{
			result = -1;
		}
		else if (keylen != 24u)
		{
			result = -1;
		}
		else
		{
			<Module>.?A0x0832d670.tripledes_set3keys(ctx, (byte*)key, (byte*)(key + 8), (byte*)(key + 16));
			if (<Module>.?A0x0832d670.is_weak_key((byte*)key) != 0 || <Module>.?A0x0832d670.is_weak_key((byte*)(key + 8)) != 0 || <Module>.?A0x0832d670.is_weak_key((byte*)(key + 16)) != 0)
			{
				result = -1;
			}
			else
			{
				result = 0;
			}
		}
		return result;
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00006ECC File Offset: 0x000062CC
	internal unsafe static void do_tripledes_encrypt(_tripledes_ctx* ctx, byte* outbuf, byte* inbuf)
	{
		<Module>.?A0x0832d670.tripledes_ecb_crypt(ctx, (byte*)inbuf, outbuf, 0);
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00006EB4 File Offset: 0x000062B4
	internal unsafe static void do_tripledes_decrypt(_tripledes_ctx* ctx, byte* outbuf, byte* inbuf)
	{
		<Module>.?A0x0832d670.tripledes_ecb_crypt(ctx, (byte*)inbuf, outbuf, 1);
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x000074B0 File Offset: 0x000068B0
	internal unsafe static sbyte* des_get_info(int algo, uint* keylen, uint* blocksize, uint* contextsize, method* r_setkey, method* r_encrypt, method* r_decrypt)
	{
		if ((<Module>.?A0x0832d670.?$S1@?1??des_get_info@@YMPBDHPAI00PAP6MHPAXPAEI@ZPAP6MX122@Z4@Z@$$Q4IA & 1u) == 0u)
		{
			<Module>.?A0x0832d670.?$S1@?1??des_get_info@@YMPBDHPAI00PAP6MHPAXPAEI@ZPAP6MX122@Z4@Z@$$Q4IA |= 1u;
			try
			{
				<Module>.?A0x0832d670.?did_selftest@?1??des_get_info@@YMPBDHPAI00PAP6MHPAXPAEI@ZPAP6MX122@Z4@Z@$$Q4HA = 0;
			}
			catch
			{
				<Module>.?A0x0832d670.?$S1@?1??des_get_info@@YMPBDHPAI00PAP6MHPAXPAEI@ZPAP6MX122@Z4@Z@$$Q4IA &= 4294967294u;
				throw;
			}
		}
		if (<Module>.?A0x0832d670.?did_selftest@?1??des_get_info@@YMPBDHPAI00PAP6MHPAXPAEI@ZPAP6MX122@Z4@Z@$$Q4HA == 0)
		{
			sbyte* ptr = <Module>.?A0x0832d670.selftest();
			<Module>.?A0x0832d670.?did_selftest@?1??des_get_info@@YMPBDHPAI00PAP6MHPAXPAEI@ZPAP6MX122@Z4@Z@$$Q4HA = 1;
			if (ptr != null)
			{
				<Module>.fprintf(<Module>.__iob_func() + 64, (sbyte*)(&<Module>.?A0x0832d670.unnamed-global-4), ptr);
				<Module>.?A0x0832d670.selftest_failed = ptr;
				return null;
			}
		}
		sbyte* result;
		if (algo == 2)
		{
			*keylen = 192u;
			*blocksize = 8u;
			*contextsize = 768u;
			*(int*)r_setkey = (int)ldftn(?A0x0832d670.do_tripledes_setkey);
			*(int*)r_encrypt = (int)ldftn(?A0x0832d670.do_tripledes_encrypt);
			*(int*)r_decrypt = (int)ldftn(?A0x0832d670.do_tripledes_decrypt);
			result = (sbyte*)(&<Module>.?A0x0832d670.unnamed-global-5);
		}
		else
		{
			result = null;
		}
		return result;
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x0000C4D4 File Offset: 0x0000B8D4
	internal static void ??__E?A0xfe8bfdd9@SA_Yes@@YMXXZ()
	{
		<Module>.?A0xfe8bfdd9.SA_Yes = (YesNoMaybe)268370176;
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x0000C4EC File Offset: 0x0000B8EC
	internal static void ??__E?A0xfe8bfdd9@SA_No@@YMXXZ()
	{
		<Module>.?A0xfe8bfdd9.SA_No = (YesNoMaybe)268369921;
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x0000C504 File Offset: 0x0000B904
	internal static void ??__E?A0xfe8bfdd9@SA_Maybe@@YMXXZ()
	{
		<Module>.?A0xfe8bfdd9.SA_Maybe = (YesNoMaybe)268369936;
	}

	// Token: 0x060000AA RID: 170 RVA: 0x0000C51C File Offset: 0x0000B91C
	internal static void ??__E?A0xfe8bfdd9@SA_NoAccess@@YMXXZ()
	{
		<Module>.?A0xfe8bfdd9.SA_NoAccess = (AccessType)0;
	}

	// Token: 0x060000AB RID: 171 RVA: 0x0000C530 File Offset: 0x0000B930
	internal static void ??__E?A0xfe8bfdd9@SA_Read@@YMXXZ()
	{
		<Module>.?A0xfe8bfdd9.SA_Read = (AccessType)1;
	}

	// Token: 0x060000AC RID: 172 RVA: 0x0000C544 File Offset: 0x0000B944
	internal static void ??__E?A0xfe8bfdd9@SA_Write@@YMXXZ()
	{
		<Module>.?A0xfe8bfdd9.SA_Write = (AccessType)2;
	}

	// Token: 0x060000AD RID: 173 RVA: 0x0000C558 File Offset: 0x0000B958
	internal static void ??__E?A0xfe8bfdd9@SA_ReadWrite@@YMXXZ()
	{
		<Module>.?A0xfe8bfdd9.SA_ReadWrite = (AccessType)3;
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00001000 File Offset: 0x00000400
	internal unsafe static sbyte* strchr(sbyte* _Str, int _Ch)
	{
		return <Module>.strchr((sbyte*)_Str, _Ch);
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00001018 File Offset: 0x00000418
	internal unsafe static sbyte* strstr(sbyte* _Str, sbyte* _SubStr)
	{
		return <Module>.strstr((sbyte*)_Str, _SubStr);
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x000075B0 File Offset: 0x000069B0
	[STAThread]
	internal static int main(string[] args)
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run(new Form1());
		return 0;
	}

	// Token: 0x060000B1 RID: 177
	[SuppressUnmanagedCodeSecurity]
	[DllImport("KERNEL32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public unsafe static extern method GetProcAddress(HINSTANCE__*, sbyte*);

	// Token: 0x060000B2 RID: 178
	[SuppressUnmanagedCodeSecurity]
	[DllImport("KERNEL32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public unsafe static extern void ReleaseActCtx(void*);

	// Token: 0x060000B3 RID: 179
	[SuppressUnmanagedCodeSecurity]
	[DllImport("KERNEL32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int DeactivateActCtx(uint, uint);

	// Token: 0x060000B4 RID: 180
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public static extern int clock();

	// Token: 0x060000B5 RID: 181
	[SuppressUnmanagedCodeSecurity]
	[DllImport("KERNEL32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public unsafe static extern int ActivateActCtx(void*, uint*);

	// Token: 0x060000B6 RID: 182
	[SuppressUnmanagedCodeSecurity]
	[DllImport("KERNEL32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public unsafe static extern void* CreateActCtxW(tagACTCTXW*);

	// Token: 0x060000B7 RID: 183
	[SuppressUnmanagedCodeSecurity]
	[DllImport("KERNEL32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public unsafe static extern HINSTANCE__* GetModuleHandleW(char*);

	// Token: 0x060000B8 RID: 184
	[SuppressUnmanagedCodeSecurity]
	[DllImport("msvcm90.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?ThrowModuleLoadException@<CrtImplementationDetails>@@YAXP$AAVString@System@@P$AAVException@3@@Z", SetLastError = true)]
	public static extern void <CrtImplementationDetails>.ThrowModuleLoadException(string, Exception);

	// Token: 0x060000B9 RID: 185
	[SuppressUnmanagedCodeSecurity]
	[DllImport("msvcm90.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?ThrowModuleLoadException@<CrtImplementationDetails>@@YAXP$AAVString@System@@@Z", SetLastError = true)]
	public static extern void <CrtImplementationDetails>.ThrowModuleLoadException(string);

	// Token: 0x060000BA RID: 186
	[SuppressUnmanagedCodeSecurity]
	[DllImport("msvcm90.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?DoDllLanguageSupportValidation@<CrtImplementationDetails>@@YAXXZ", SetLastError = true)]
	public static extern void <CrtImplementationDetails>.DoDllLanguageSupportValidation();

	// Token: 0x060000BB RID: 187
	[SuppressUnmanagedCodeSecurity]
	[DllImport("msvcm90.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?ThrowNestedModuleLoadException@<CrtImplementationDetails>@@YAXP$AAVException@System@@0@Z", SetLastError = true)]
	public static extern void <CrtImplementationDetails>.ThrowNestedModuleLoadException(Exception, Exception);

	// Token: 0x060000BC RID: 188
	[SuppressUnmanagedCodeSecurity]
	[DllImport("msvcm90.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?RegisterModuleUninitializer@<CrtImplementationDetails>@@YAXP$AAVEventHandler@System@@@Z", SetLastError = true)]
	public static extern void <CrtImplementationDetails>.RegisterModuleUninitializer(EventHandler);

	// Token: 0x060000BD RID: 189
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern void* _encode_pointer(void*);

	// Token: 0x060000BE RID: 190
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern void* _decode_pointer(void*);

	// Token: 0x060000BF RID: 191
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern void* _encoded_null();

	// Token: 0x060000C0 RID: 192
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern void* __AdjustPointer(void*, PMD*);

	// Token: 0x060000C1 RID: 193
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?_inconsistency@@YAXXZ", SetLastError = true)]
	public static extern void _inconsistency();

	// Token: 0x060000C2 RID: 194
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern int _IsExceptionObjectToBeDestroyed(void*);

	// Token: 0x060000C3 RID: 195
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?terminate@@YAXXZ", SetLastError = true)]
	public static extern void terminate();

	// Token: 0x060000C4 RID: 196
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?_ValidateRead@@YAHPBXI@Z", SetLastError = true)]
	public unsafe static extern int _ValidateRead(void*, uint);

	// Token: 0x060000C5 RID: 197
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern _tiddata* _getptd();

	// Token: 0x060000C6 RID: 198
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern FrameInfo* _CreateFrameInfo(FrameInfo*, void*);

	// Token: 0x060000C7 RID: 199
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern int strcmp(sbyte*, sbyte*);

	// Token: 0x060000C8 RID: 200
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?_ValidateWrite@@YAHPAXI@Z", SetLastError = true)]
	public unsafe static extern int _ValidateWrite(void*, uint);

	// Token: 0x060000C9 RID: 201
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern void _FindAndUnlinkFrame(FrameInfo*);

	// Token: 0x060000CA RID: 202
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?_ValidateExecute@@YAHP6GHXZ@Z", SetLastError = true)]
	public static extern int _ValidateExecute(method);

	// Token: 0x060000CB RID: 203
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern void* memmove(void*, void*, uint);

	// Token: 0x060000CC RID: 204
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern int __FrameUnwindFilter(_EXCEPTION_POINTERS*);

	// Token: 0x060000CD RID: 205
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??3@YAXPAX@Z", SetLastError = true)]
	public unsafe static extern void delete(void*);

	// Token: 0x060000CE RID: 206
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern int strcpy_s(sbyte*, uint, sbyte*);

	// Token: 0x060000CF RID: 207
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern void* __unDNameHelper(sbyte*, sbyte*, int, ushort);

	// Token: 0x060000D0 RID: 208
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern uint strlen(sbyte*);

	// Token: 0x060000D1 RID: 209
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern void* malloc(uint);

	// Token: 0x060000D2 RID: 210
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern void free(void*);

	// Token: 0x060000D3 RID: 211
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern void _invoke_watson(char*, char*, char*, uint, uint);

	// Token: 0x060000D4 RID: 212
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern int fprintf(_iobuf*, sbyte*, __arglist);

	// Token: 0x060000D5 RID: 213
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern _iobuf* __iob_func();

	// Token: 0x060000D6 RID: 214
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern int memcmp(void*, void*, uint);

	// Token: 0x060000D7 RID: 215
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern void* memcpy(void*, void*, uint);

	// Token: 0x060000D8 RID: 216
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern int sscanf_s(sbyte*, sbyte*, __arglist);

	// Token: 0x060000D9 RID: 217
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern uint fwrite(void*, uint, uint, _iobuf*);

	// Token: 0x060000DA RID: 218
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern int printf(sbyte*, __arglist);

	// Token: 0x060000DB RID: 219
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern int fseek(_iobuf*, int, int);

	// Token: 0x060000DC RID: 220
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern uint fread(void*, uint, uint, _iobuf*);

	// Token: 0x060000DD RID: 221
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern int fclose(_iobuf*);

	// Token: 0x060000DE RID: 222
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern int fopen_s(_iobuf**, sbyte*, sbyte*);

	// Token: 0x060000DF RID: 223
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern sbyte* strstr(sbyte*, sbyte*);

	// Token: 0x060000E0 RID: 224
	[SuppressUnmanagedCodeSecurity]
	[DllImport("MSVCR90.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	public unsafe static extern sbyte* strchr(sbyte*, int);

	// Token: 0x04000001 RID: 1 RVA: 0x0000D22C File Offset: 0x0000C22C
	internal static ??_C@_1BC@EKMDCNOB@?$AAK?$AAE?$AAR?$AAN?$AAE?$AAL?$AA3?$AA2?$AA?$AA@$$BY0A@$$CB_W ??_C@_1BC@EKMDCNOB@?$AAK?$AAE?$AAR?$AAN?$AAE?$AAL?$AA3?$AA2?$AA?$AA@;

	// Token: 0x04000002 RID: 2 RVA: 0x0000D21C File Offset: 0x0000C21C
	internal static ??_C@_0O@JKAFBCMB@CreateActCtxW?$AA@$$BY0A@$$CBD ??_C@_0O@JKAFBCMB@CreateActCtxW?$AA@;

	// Token: 0x04000003 RID: 3
	[FixedAddressValueType]
	internal static int ?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA;

	// Token: 0x04000004 RID: 4 RVA: 0x0000D030 File Offset: 0x0000C030
	internal static method ?Uninitialized$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000005 RID: 5 RVA: 0x0000D1E8 File Offset: 0x0000C1E8
	internal static $ArrayType$$$BY00Q6MPBXXZ __xi_vt_a;

	// Token: 0x04000006 RID: 6
	[FixedAddressValueType]
	internal static double _HUGE;

	// Token: 0x04000007 RID: 7
	[FixedAddressValueType]
	internal static AccessType SA_Write;

	// Token: 0x04000008 RID: 8 RVA: 0x0000D028 File Offset: 0x0000C028
	internal static method _HUGE$initializer$;

	// Token: 0x04000009 RID: 9
	[FixedAddressValueType]
	internal static Progress.State ?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x0400000A RID: 10 RVA: 0x0000D044 File Offset: 0x0000C044
	internal static method ?InitializedPerAppDomain$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x0400000B RID: 11
	[FixedAddressValueType]
	internal static double HUGE;

	// Token: 0x0400000C RID: 12
	[FixedAddressValueType]
	internal static AccessType SA_NoAccess;

	// Token: 0x0400000D RID: 13 RVA: 0x0000D018 File Offset: 0x0000C018
	internal static method SA_NoAccess$initializer$;

	// Token: 0x0400000E RID: 14
	[FixedAddressValueType]
	internal static AccessType SA_ReadWrite;

	// Token: 0x0400000F RID: 15 RVA: 0x0000D024 File Offset: 0x0000C024
	internal static method SA_ReadWrite$initializer$;

	// Token: 0x04000010 RID: 16
	[FixedAddressValueType]
	internal static bool ?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA;

	// Token: 0x04000011 RID: 17 RVA: 0x0000D034 File Offset: 0x0000C034
	internal static method ?IsDefaultDomain$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000012 RID: 18
	[FixedAddressValueType]
	internal static YesNoMaybe SA_Yes;

	// Token: 0x04000013 RID: 19 RVA: 0x0000D1E0 File Offset: 0x0000C1E0
	internal static method HUGE$initializer$;

	// Token: 0x04000014 RID: 20 RVA: 0x0000D020 File Offset: 0x0000C020
	internal static method SA_Write$initializer$;

	// Token: 0x04000015 RID: 21 RVA: 0x0000D00C File Offset: 0x0000C00C
	internal static method SA_Yes$initializer$;

	// Token: 0x04000016 RID: 22
	[FixedAddressValueType]
	internal static YesNoMaybe SA_Maybe;

	// Token: 0x04000017 RID: 23 RVA: 0x0000D008 File Offset: 0x0000C008
	internal static $ArrayType$$$BY00Q6MPBXXZ __xc_ma_a;

	// Token: 0x04000018 RID: 24
	[FixedAddressValueType]
	internal static AccessType SA_Read;

	// Token: 0x04000019 RID: 25
	[FixedAddressValueType]
	internal static YesNoMaybe SA_No;

	// Token: 0x0400001A RID: 26
	[FixedAddressValueType]
	internal static Progress.State ?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x0400001B RID: 27 RVA: 0x0000D03C File Offset: 0x0000C03C
	internal static method ?InitializedNative$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x0400001C RID: 28
	[FixedAddressValueType]
	internal static int ?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA;

	// Token: 0x0400001D RID: 29 RVA: 0x0000D02C File Offset: 0x0000C02C
	internal static method ?Initialized$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x0400001E RID: 30 RVA: 0x0000D1E4 File Offset: 0x0000C1E4
	internal static $ArrayType$$$BY00Q6MPBXXZ __xc_ma_z;

	// Token: 0x0400001F RID: 31
	[FixedAddressValueType]
	internal static Progress.State ?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x04000020 RID: 32 RVA: 0x0000D038 File Offset: 0x0000C038
	internal static method ?InitializedVtables$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000021 RID: 33 RVA: 0x0000D01C File Offset: 0x0000C01C
	internal static method SA_Read$initializer$;

	// Token: 0x04000022 RID: 34 RVA: 0x0000D1F0 File Offset: 0x0000C1F0
	internal static $ArrayType$$$BY00Q6MPBXXZ __xi_vt_z;

	// Token: 0x04000023 RID: 35
	[FixedAddressValueType]
	internal static Progress.State ?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x04000024 RID: 36 RVA: 0x0000D040 File Offset: 0x0000C040
	internal static method ?InitializedPerProcess$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000025 RID: 37 RVA: 0x0000D014 File Offset: 0x0000C014
	internal static method SA_Maybe$initializer$;

	// Token: 0x04000026 RID: 38 RVA: 0x0000D010 File Offset: 0x0000C010
	internal static method SA_No$initializer$;

	// Token: 0x04000027 RID: 39
	[FixedAddressValueType]
	internal static uint __exit_list_size_app_domain;

	// Token: 0x04000028 RID: 40
	[FixedAddressValueType]
	internal unsafe static method* __onexitbegin_app_domain;

	// Token: 0x04000029 RID: 41
	[FixedAddressValueType]
	internal static AccessType SA_Write;

	// Token: 0x0400002A RID: 42
	[FixedAddressValueType]
	internal static AccessType SA_NoAccess;

	// Token: 0x0400002B RID: 43 RVA: 0x0000D054 File Offset: 0x0000C054
	internal static method SA_NoAccess$initializer$;

	// Token: 0x0400002C RID: 44
	[FixedAddressValueType]
	internal static AccessType SA_ReadWrite;

	// Token: 0x0400002D RID: 45 RVA: 0x0000D060 File Offset: 0x0000C060
	internal static method SA_ReadWrite$initializer$;

	// Token: 0x0400002E RID: 46
	[FixedAddressValueType]
	internal static YesNoMaybe SA_Yes;

	// Token: 0x0400002F RID: 47 RVA: 0x0000D05C File Offset: 0x0000C05C
	internal static method SA_Write$initializer$;

	// Token: 0x04000030 RID: 48 RVA: 0x0000D048 File Offset: 0x0000C048
	internal static method SA_Yes$initializer$;

	// Token: 0x04000031 RID: 49
	[FixedAddressValueType]
	internal static YesNoMaybe SA_Maybe;

	// Token: 0x04000032 RID: 50
	[FixedAddressValueType]
	internal unsafe static method* __onexitend_app_domain;

	// Token: 0x04000033 RID: 51
	[FixedAddressValueType]
	internal static AccessType SA_Read;

	// Token: 0x04000034 RID: 52
	[FixedAddressValueType]
	internal static YesNoMaybe SA_No;

	// Token: 0x04000035 RID: 53 RVA: 0x0000D058 File Offset: 0x0000C058
	internal static method SA_Read$initializer$;

	// Token: 0x04000036 RID: 54
	[FixedAddressValueType]
	internal unsafe static void* ?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA;

	// Token: 0x04000037 RID: 55
	[FixedAddressValueType]
	internal static int ?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA;

	// Token: 0x04000038 RID: 56 RVA: 0x0000D050 File Offset: 0x0000C050
	internal static method SA_Maybe$initializer$;

	// Token: 0x04000039 RID: 57 RVA: 0x0000D04C File Offset: 0x0000C04C
	internal static method SA_No$initializer$;

	// Token: 0x0400003A RID: 58
	[FixedAddressValueType]
	internal static AccessType SA_Write;

	// Token: 0x0400003B RID: 59
	[FixedAddressValueType]
	internal static AccessType SA_NoAccess;

	// Token: 0x0400003C RID: 60 RVA: 0x0000D070 File Offset: 0x0000C070
	internal static method SA_NoAccess$initializer$;

	// Token: 0x0400003D RID: 61
	[FixedAddressValueType]
	internal static AccessType SA_ReadWrite;

	// Token: 0x0400003E RID: 62 RVA: 0x0000D07C File Offset: 0x0000C07C
	internal static method SA_ReadWrite$initializer$;

	// Token: 0x0400003F RID: 63
	[FixedAddressValueType]
	internal static YesNoMaybe SA_Yes;

	// Token: 0x04000040 RID: 64 RVA: 0x0000D078 File Offset: 0x0000C078
	internal static method SA_Write$initializer$;

	// Token: 0x04000041 RID: 65 RVA: 0x0000D064 File Offset: 0x0000C064
	internal static method SA_Yes$initializer$;

	// Token: 0x04000042 RID: 66
	[FixedAddressValueType]
	internal static YesNoMaybe SA_Maybe;

	// Token: 0x04000043 RID: 67
	[FixedAddressValueType]
	internal static AccessType SA_Read;

	// Token: 0x04000044 RID: 68
	[FixedAddressValueType]
	internal static YesNoMaybe SA_No;

	// Token: 0x04000045 RID: 69 RVA: 0x0000D074 File Offset: 0x0000C074
	internal static method SA_Read$initializer$;

	// Token: 0x04000046 RID: 70 RVA: 0x0000D06C File Offset: 0x0000C06C
	internal static method SA_Maybe$initializer$;

	// Token: 0x04000047 RID: 71 RVA: 0x0000D068 File Offset: 0x0000C068
	internal static method SA_No$initializer$;

	// Token: 0x04000048 RID: 72
	[FixedAddressValueType]
	internal static AccessType SA_Write;

	// Token: 0x04000049 RID: 73
	[FixedAddressValueType]
	internal static AccessType SA_NoAccess;

	// Token: 0x0400004A RID: 74 RVA: 0x0000D08C File Offset: 0x0000C08C
	internal static method SA_NoAccess$initializer$;

	// Token: 0x0400004B RID: 75
	[FixedAddressValueType]
	internal static AccessType SA_ReadWrite;

	// Token: 0x0400004C RID: 76 RVA: 0x0000D098 File Offset: 0x0000C098
	internal static method SA_ReadWrite$initializer$;

	// Token: 0x0400004D RID: 77
	[FixedAddressValueType]
	internal static YesNoMaybe SA_Yes;

	// Token: 0x0400004E RID: 78 RVA: 0x0000D094 File Offset: 0x0000C094
	internal static method SA_Write$initializer$;

	// Token: 0x0400004F RID: 79 RVA: 0x0000D080 File Offset: 0x0000C080
	internal static method SA_Yes$initializer$;

	// Token: 0x04000050 RID: 80
	[FixedAddressValueType]
	internal static YesNoMaybe SA_Maybe;

	// Token: 0x04000051 RID: 81
	[FixedAddressValueType]
	internal static AccessType SA_Read;

	// Token: 0x04000052 RID: 82
	[FixedAddressValueType]
	internal static YesNoMaybe SA_No;

	// Token: 0x04000053 RID: 83 RVA: 0x0000D090 File Offset: 0x0000C090
	internal static method SA_Read$initializer$;

	// Token: 0x04000054 RID: 84 RVA: 0x0000D088 File Offset: 0x0000C088
	internal static method SA_Maybe$initializer$;

	// Token: 0x04000055 RID: 85 RVA: 0x0000D084 File Offset: 0x0000C084
	internal static method SA_No$initializer$;

	// Token: 0x04000056 RID: 86 RVA: 0x0000D288 File Offset: 0x0000C288
	internal static ??_C@_0BA@NOJDBDJO@?4?$DPAVtype_info?$EA?$EA?$AA@$$BY0A@$$CBD ??_C@_0BA@NOJDBDJO@?4?$DPAVtype_info?$EA?$EA?$AA@;

	// Token: 0x04000057 RID: 87
	[FixedAddressValueType]
	internal static $_s__RTTIBaseClassArray$_extraBytes_4 ??_R2type_info@@8;

	// Token: 0x04000058 RID: 88 RVA: 0x0000D0F8 File Offset: 0x0000C0F8
	internal static method ??_R2type_info@@8$initializer$;

	// Token: 0x04000059 RID: 89
	[FixedAddressValueType]
	internal static _s__RTTICompleteObjectLocator ??_R4type_info@@6B@;

	// Token: 0x0400005A RID: 90 RVA: 0x0000D138 File Offset: 0x0000C138
	internal static method ??_R4type_info@@6B@$initializer$;

	// Token: 0x0400005B RID: 91
	[FixedAddressValueType]
	internal static $ArrayType$$$BY01Q6MXXZ ??_7type_info@@6B@;

	// Token: 0x0400005C RID: 92
	[FixedAddressValueType]
	internal static AccessType SA_Write;

	// Token: 0x0400005D RID: 93
	[FixedAddressValueType]
	internal static _s__RTTIClassHierarchyDescriptor ??_R3type_info@@8;

	// Token: 0x0400005E RID: 94
	[FixedAddressValueType]
	internal static AccessType SA_NoAccess;

	// Token: 0x0400005F RID: 95 RVA: 0x0000D0A8 File Offset: 0x0000C0A8
	internal static method SA_NoAccess$initializer$;

	// Token: 0x04000060 RID: 96
	[FixedAddressValueType]
	internal static AccessType SA_ReadWrite;

	// Token: 0x04000061 RID: 97 RVA: 0x0000D0B4 File Offset: 0x0000C0B4
	internal static method SA_ReadWrite$initializer$;

	// Token: 0x04000062 RID: 98
	[FixedAddressValueType]
	internal static YesNoMaybe SA_Yes;

	// Token: 0x04000063 RID: 99 RVA: 0x0000D0B0 File Offset: 0x0000C0B0
	internal static method SA_Write$initializer$;

	// Token: 0x04000064 RID: 100 RVA: 0x0000D09C File Offset: 0x0000C09C
	internal static method SA_Yes$initializer$;

	// Token: 0x04000065 RID: 101
	[FixedAddressValueType]
	internal static YesNoMaybe SA_Maybe;

	// Token: 0x04000066 RID: 102 RVA: 0x0000D118 File Offset: 0x0000C118
	internal static method ??_R3type_info@@8$initializer$;

	// Token: 0x04000067 RID: 103
	[FixedAddressValueType]
	internal static AccessType SA_Read;

	// Token: 0x04000068 RID: 104
	[FixedAddressValueType]
	internal static YesNoMaybe SA_No;

	// Token: 0x04000069 RID: 105 RVA: 0x0000D0AC File Offset: 0x0000C0AC
	internal static method SA_Read$initializer$;

	// Token: 0x0400006A RID: 106
	[FixedAddressValueType]
	internal static $_TypeDescriptor$_extraBytes_16 ??_R0?AVtype_info@@@8;

	// Token: 0x0400006B RID: 107 RVA: 0x0000D0B8 File Offset: 0x0000C0B8
	internal static method ??_R0?AVtype_info@@@8$initializer$;

	// Token: 0x0400006C RID: 108 RVA: 0x0000D0A4 File Offset: 0x0000C0A4
	internal static method SA_Maybe$initializer$;

	// Token: 0x0400006D RID: 109 RVA: 0x0000D1EC File Offset: 0x0000C1EC
	internal static method ??_7type_info@@6B@$initializer$;

	// Token: 0x0400006E RID: 110 RVA: 0x0000D0A0 File Offset: 0x0000C0A0
	internal static method SA_No$initializer$;

	// Token: 0x0400006F RID: 111
	[FixedAddressValueType]
	internal static _s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@type_info@@8;

	// Token: 0x04000070 RID: 112
	[FixedAddressValueType]
	internal static __type_info_node __type_info_root_node;

	// Token: 0x04000071 RID: 113 RVA: 0x0000D0D8 File Offset: 0x0000C0D8
	internal static method ??_R1A@?0A@EA@type_info@@8$initializer$;

	// Token: 0x04000072 RID: 114
	[FixedAddressValueType]
	internal static AccessType SA_Write;

	// Token: 0x04000073 RID: 115
	[FixedAddressValueType]
	internal static AccessType SA_NoAccess;

	// Token: 0x04000074 RID: 116 RVA: 0x0000D164 File Offset: 0x0000C164
	internal static method SA_NoAccess$initializer$;

	// Token: 0x04000075 RID: 117
	[FixedAddressValueType]
	internal static AccessType SA_ReadWrite;

	// Token: 0x04000076 RID: 118 RVA: 0x0000D170 File Offset: 0x0000C170
	internal static method SA_ReadWrite$initializer$;

	// Token: 0x04000077 RID: 119
	[FixedAddressValueType]
	internal static YesNoMaybe SA_Yes;

	// Token: 0x04000078 RID: 120 RVA: 0x0000D16C File Offset: 0x0000C16C
	internal static method SA_Write$initializer$;

	// Token: 0x04000079 RID: 121 RVA: 0x0000D158 File Offset: 0x0000C158
	internal static method SA_Yes$initializer$;

	// Token: 0x0400007A RID: 122
	[FixedAddressValueType]
	internal static YesNoMaybe SA_Maybe;

	// Token: 0x0400007B RID: 123
	[FixedAddressValueType]
	internal static AccessType SA_Read;

	// Token: 0x0400007C RID: 124
	[FixedAddressValueType]
	internal static YesNoMaybe SA_No;

	// Token: 0x0400007D RID: 125 RVA: 0x0000D168 File Offset: 0x0000C168
	internal static method SA_Read$initializer$;

	// Token: 0x0400007E RID: 126 RVA: 0x0000D160 File Offset: 0x0000C160
	internal static method SA_Maybe$initializer$;

	// Token: 0x0400007F RID: 127 RVA: 0x0000D15C File Offset: 0x0000C15C
	internal static method SA_No$initializer$;

	// Token: 0x04000080 RID: 128
	[FixedAddressValueType]
	internal static $ArrayType$$$BY0BAA@K crc32_tab;

	// Token: 0x04000081 RID: 129 RVA: 0x0000D174 File Offset: 0x0000C174
	internal static method crc32_tab$initializer$;

	// Token: 0x04000082 RID: 130 RVA: 0x0000D2AC File Offset: 0x0000C2AC
	internal static $ArrayType$$$BY0CE@$$CBD unnamed-global-0;

	// Token: 0x04000083 RID: 131 RVA: 0x0000D2D0 File Offset: 0x0000C2D0
	internal static $ArrayType$$$BY0BN@$$CBD unnamed-global-1;

	// Token: 0x04000084 RID: 132 RVA: 0x0000D2F0 File Offset: 0x0000C2F0
	internal static $ArrayType$$$BY0BI@$$CBD unnamed-global-2;

	// Token: 0x04000085 RID: 133 RVA: 0x0000D308 File Offset: 0x0000C308
	internal static $ArrayType$$$BY0BO@$$CBD unnamed-global-3;

	// Token: 0x04000086 RID: 134 RVA: 0x0000D328 File Offset: 0x0000C328
	internal static $ArrayType$$$BY03$$CBD unnamed-global-4;

	// Token: 0x04000087 RID: 135 RVA: 0x0000D32C File Offset: 0x0000C32C
	internal static $ArrayType$$$BY04$$CBD unnamed-global-5;

	// Token: 0x04000088 RID: 136
	[FixedAddressValueType]
	internal static $ArrayType$$$BY0EA@I sbox3;

	// Token: 0x04000089 RID: 137 RVA: 0x0000D19C File Offset: 0x0000C19C
	internal static method sbox3$initializer$;

	// Token: 0x0400008A RID: 138
	[FixedAddressValueType]
	internal static $ArrayType$$$BY0EA@I sbox1;

	// Token: 0x0400008B RID: 139 RVA: 0x0000D194 File Offset: 0x0000C194
	internal static method sbox1$initializer$;

	// Token: 0x0400008C RID: 140
	[FixedAddressValueType]
	internal static $ArrayType$$$BY0EA@I sbox5;

	// Token: 0x0400008D RID: 141
	[FixedAddressValueType]
	internal static $ArrayType$$$BY0EA@I sbox4;

	// Token: 0x0400008E RID: 142
	[FixedAddressValueType]
	internal static $ArrayType$$$BY0BA@E encrypt_rotate_tab;

	// Token: 0x0400008F RID: 143 RVA: 0x0000D1BC File Offset: 0x0000C1BC
	internal static method encrypt_rotate_tab$initializer$;

	// Token: 0x04000090 RID: 144
	[FixedAddressValueType]
	internal static AccessType SA_Write;

	// Token: 0x04000091 RID: 145
	[FixedAddressValueType]
	internal static leftkey_swap$$BY0A@I leftkey_swap;

	// Token: 0x04000092 RID: 146 RVA: 0x0000D1B4 File Offset: 0x0000C1B4
	internal static method leftkey_swap$initializer$;

	// Token: 0x04000093 RID: 147
	[FixedAddressValueType]
	internal static uint ?$S1@?1??des_get_info@@YMPBDHPAI00PAP6MHPAXPAEI@ZPAP6MX122@Z4@Z@$$Q4IA;

	// Token: 0x04000094 RID: 148
	[FixedAddressValueType]
	internal static AccessType SA_NoAccess;

	// Token: 0x04000095 RID: 149 RVA: 0x0000D184 File Offset: 0x0000C184
	internal static method SA_NoAccess$initializer$;

	// Token: 0x04000096 RID: 150
	[FixedAddressValueType]
	internal static AccessType SA_ReadWrite;

	// Token: 0x04000097 RID: 151 RVA: 0x0000D190 File Offset: 0x0000C190
	internal static method SA_ReadWrite$initializer$;

	// Token: 0x04000098 RID: 152
	[FixedAddressValueType]
	internal static YesNoMaybe SA_Yes;

	// Token: 0x04000099 RID: 153
	[FixedAddressValueType]
	internal static rightkey_swap$$BY0A@I rightkey_swap;

	// Token: 0x0400009A RID: 154 RVA: 0x0000D1B8 File Offset: 0x0000C1B8
	internal static method rightkey_swap$initializer$;

	// Token: 0x0400009B RID: 155 RVA: 0x0000D18C File Offset: 0x0000C18C
	internal static method SA_Write$initializer$;

	// Token: 0x0400009C RID: 156 RVA: 0x0000D178 File Offset: 0x0000C178
	internal static method SA_Yes$initializer$;

	// Token: 0x0400009D RID: 157
	[FixedAddressValueType]
	internal static YesNoMaybe SA_Maybe;

	// Token: 0x0400009E RID: 158
	[FixedAddressValueType]
	internal static $ArrayType$$$BY0EA@I sbox7;

	// Token: 0x0400009F RID: 159 RVA: 0x0000D1AC File Offset: 0x0000C1AC
	internal static method sbox7$initializer$;

	// Token: 0x040000A0 RID: 160
	[FixedAddressValueType]
	internal static AccessType SA_Read;

	// Token: 0x040000A1 RID: 161
	[FixedAddressValueType]
	internal static $ArrayType$$$BY0EA@I sbox2;

	// Token: 0x040000A2 RID: 162 RVA: 0x0000D198 File Offset: 0x0000C198
	internal static method sbox2$initializer$;

	// Token: 0x040000A3 RID: 163
	[FixedAddressValueType]
	internal static $ArrayType$$$BY0EA@I sbox6;

	// Token: 0x040000A4 RID: 164 RVA: 0x0000D1A8 File Offset: 0x0000C1A8
	internal static method sbox6$initializer$;

	// Token: 0x040000A5 RID: 165
	[FixedAddressValueType]
	internal static YesNoMaybe SA_No;

	// Token: 0x040000A6 RID: 166 RVA: 0x0000D188 File Offset: 0x0000C188
	internal static method SA_Read$initializer$;

	// Token: 0x040000A7 RID: 167 RVA: 0x0000D1A4 File Offset: 0x0000C1A4
	internal static method sbox5$initializer$;

	// Token: 0x040000A8 RID: 168 RVA: 0x0000D1A0 File Offset: 0x0000C1A0
	internal static method sbox4$initializer$;

	// Token: 0x040000A9 RID: 169
	[FixedAddressValueType]
	internal static int ?did_selftest@?1??des_get_info@@YMPBDHPAI00PAP6MHPAXPAEI@ZPAP6MX122@Z4@Z@$$Q4HA;

	// Token: 0x040000AA RID: 170
	[FixedAddressValueType]
	internal static $ArrayType$$$BY1EA@7E weak_keys;

	// Token: 0x040000AB RID: 171 RVA: 0x0000D1C0 File Offset: 0x0000C1C0
	internal static method weak_keys$initializer$;

	// Token: 0x040000AC RID: 172
	[FixedAddressValueType]
	internal unsafe static sbyte* selftest_failed;

	// Token: 0x040000AD RID: 173
	[FixedAddressValueType]
	internal static $ArrayType$$$BY0EA@I sbox8;

	// Token: 0x040000AE RID: 174 RVA: 0x0000D1B0 File Offset: 0x0000C1B0
	internal static method sbox8$initializer$;

	// Token: 0x040000AF RID: 175 RVA: 0x0000D180 File Offset: 0x0000C180
	internal static method SA_Maybe$initializer$;

	// Token: 0x040000B0 RID: 176 RVA: 0x0000D17C File Offset: 0x0000C17C
	internal static method SA_No$initializer$;

	// Token: 0x040000B1 RID: 177 RVA: 0x0000D334 File Offset: 0x0000C334
	internal static ??_C@_02JDPG@rb?$AA@$$BY0A@$$CBD ??_C@_02JDPG@rb?$AA@;

	// Token: 0x040000B2 RID: 178 RVA: 0x0000D338 File Offset: 0x0000C338
	internal static ??_C@_07NKOFPJFH@?$ABCD001?$AB?$AA@$$BY0A@$$CBD ??_C@_07NKOFPJFH@?$ABCD001?$AB?$AA@;

	// Token: 0x040000B3 RID: 179 RVA: 0x0000D340 File Offset: 0x0000C340
	internal static ??_C@_04GKHLBAIJ@?4bin?$AA@$$BY0A@$$CBD ??_C@_04GKHLBAIJ@?4bin?$AA@;

	// Token: 0x040000B4 RID: 180 RVA: 0x0000D348 File Offset: 0x0000C348
	internal static ??_C@_04GHIANNPF@?4BIN?$AA@$$BY0A@$$CBD ??_C@_04GHIANNPF@?4BIN?$AA@;

	// Token: 0x040000B5 RID: 181 RVA: 0x0000D350 File Offset: 0x0000C350
	internal static ??_C@_03ELIABIOC@w?$CLb?$AA@$$BY0A@$$CBD ??_C@_03ELIABIOC@w?$CLb?$AA@;

	// Token: 0x040000B6 RID: 182 RVA: 0x0000D354 File Offset: 0x0000C354
	internal static ??_C@_03IKGEINEE@?$CFs?5?$AA@$$BY0A@$$CBD ??_C@_03IKGEINEE@?$CFs?5?$AA@;

	// Token: 0x040000B7 RID: 183 RVA: 0x0000D358 File Offset: 0x0000C358
	internal static ??_C@_04EPBFEBBF@?$CFX?9?$DO?$AA@$$BY0A@$$CBD ??_C@_04EPBFEBBF@?$CFX?9?$DO?$AA@;

	// Token: 0x040000B8 RID: 184 RVA: 0x0000D360 File Offset: 0x0000C360
	internal static ??_C@_03NBBHOIGN@?$CFX?6?$AA@$$BY0A@$$CBD ??_C@_03NBBHOIGN@?$CFX?6?$AA@;

	// Token: 0x040000B9 RID: 185 RVA: 0x0000D364 File Offset: 0x0000C364
	internal static ??_C@_08IKLPECHA@Skipped?6?$AA@$$BY0A@$$CBD ??_C@_08IKLPECHA@Skipped?6?$AA@;

	// Token: 0x040000BA RID: 186 RVA: 0x0000D370 File Offset: 0x0000C370
	internal static ??_C@_02EMFKHFLK@?$CFX?$AA@$$BY0A@$$CBD ??_C@_02EMFKHFLK@?$CFX?$AA@;

	// Token: 0x040000BB RID: 187
	[FixedAddressValueType]
	internal static AccessType SA_ReadWrite;

	// Token: 0x040000BC RID: 188 RVA: 0x0000D1DC File Offset: 0x0000C1DC
	internal static method SA_ReadWrite$initializer$;

	// Token: 0x040000BD RID: 189
	[FixedAddressValueType]
	internal static AccessType SA_Write;

	// Token: 0x040000BE RID: 190 RVA: 0x0000D1D8 File Offset: 0x0000C1D8
	internal static method SA_Write$initializer$;

	// Token: 0x040000BF RID: 191
	[FixedAddressValueType]
	internal static AccessType SA_Read;

	// Token: 0x040000C0 RID: 192 RVA: 0x0000D1D4 File Offset: 0x0000C1D4
	internal static method SA_Read$initializer$;

	// Token: 0x040000C1 RID: 193
	[FixedAddressValueType]
	internal static AccessType SA_NoAccess;

	// Token: 0x040000C2 RID: 194 RVA: 0x0000D1D0 File Offset: 0x0000C1D0
	internal static method SA_NoAccess$initializer$;

	// Token: 0x040000C3 RID: 195
	[FixedAddressValueType]
	internal static YesNoMaybe SA_Maybe;

	// Token: 0x040000C4 RID: 196 RVA: 0x0000D1CC File Offset: 0x0000C1CC
	internal static method SA_Maybe$initializer$;

	// Token: 0x040000C5 RID: 197
	[FixedAddressValueType]
	internal static YesNoMaybe SA_No;

	// Token: 0x040000C6 RID: 198 RVA: 0x0000D1C8 File Offset: 0x0000C1C8
	internal static method SA_No$initializer$;

	// Token: 0x040000C7 RID: 199
	[FixedAddressValueType]
	internal static YesNoMaybe SA_Yes;

	// Token: 0x040000C8 RID: 200 RVA: 0x0000D1C4 File Offset: 0x0000C1C4
	internal static method SA_Yes$initializer$;

	// Token: 0x040000C9 RID: 201
	[FixedAddressValueType]
	internal static int __@@_PchSym_@00@UgvnkUmUmzlrhlUivovzhvUhgwzucOlyq@;
}
