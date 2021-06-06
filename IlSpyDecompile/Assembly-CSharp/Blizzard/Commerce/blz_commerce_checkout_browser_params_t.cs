using System;
using System.Runtime.InteropServices;

namespace Blizzard.Commerce
{
	public class blz_commerce_checkout_browser_params_t : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public string checkout_url
		{
			get
			{
				return battlenet_commercePINVOKE.blz_commerce_checkout_browser_params_t_checkout_url_get(swigCPtr);
			}
			set
			{
				battlenet_commercePINVOKE.blz_commerce_checkout_browser_params_t_checkout_url_set(swigCPtr, value);
			}
		}

		public string title_code
		{
			get
			{
				return battlenet_commercePINVOKE.blz_commerce_checkout_browser_params_t_title_code_get(swigCPtr);
			}
			set
			{
				battlenet_commercePINVOKE.blz_commerce_checkout_browser_params_t_title_code_set(swigCPtr, value);
			}
		}

		public string device_id
		{
			get
			{
				return battlenet_commercePINVOKE.blz_commerce_checkout_browser_params_t_device_id_get(swigCPtr);
			}
			set
			{
				battlenet_commercePINVOKE.blz_commerce_checkout_browser_params_t_device_id_set(swigCPtr, value);
			}
		}

		public string title_version
		{
			get
			{
				return battlenet_commercePINVOKE.blz_commerce_checkout_browser_params_t_title_version_get(swigCPtr);
			}
			set
			{
				battlenet_commercePINVOKE.blz_commerce_checkout_browser_params_t_title_version_set(swigCPtr, value);
			}
		}

		public string locale
		{
			get
			{
				return battlenet_commercePINVOKE.blz_commerce_checkout_browser_params_t_locale_get(swigCPtr);
			}
			set
			{
				battlenet_commercePINVOKE.blz_commerce_checkout_browser_params_t_locale_set(swigCPtr, value);
			}
		}

		public string game_service_region
		{
			get
			{
				return battlenet_commercePINVOKE.blz_commerce_checkout_browser_params_t_game_service_region_get(swigCPtr);
			}
			set
			{
				battlenet_commercePINVOKE.blz_commerce_checkout_browser_params_t_game_service_region_set(swigCPtr, value);
			}
		}

		public string game_account_id
		{
			get
			{
				return battlenet_commercePINVOKE.blz_commerce_checkout_browser_params_t_game_account_id_get(swigCPtr);
			}
			set
			{
				battlenet_commercePINVOKE.blz_commerce_checkout_browser_params_t_game_account_id_set(swigCPtr, value);
			}
		}

		internal blz_commerce_checkout_browser_params_t(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		internal static HandleRef getCPtr(blz_commerce_checkout_browser_params_t obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		~blz_commerce_checkout_browser_params_t()
		{
			Dispose(disposing: false);
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			lock (this)
			{
				if (swigCPtr.Handle != IntPtr.Zero)
				{
					if (swigCMemOwn)
					{
						swigCMemOwn = false;
						battlenet_commercePINVOKE.delete_blz_commerce_checkout_browser_params_t(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public blz_commerce_checkout_browser_params_t()
			: this(battlenet_commercePINVOKE.new_blz_commerce_checkout_browser_params_t(), cMemoryOwn: true)
		{
		}
	}
}
