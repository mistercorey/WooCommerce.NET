using System;
using System.Runtime.Serialization;
using WooCommerceNET.Base;

namespace WooCommerceNET.WooCommerce
{
    [DataContract]
	public class Subscription : JsonObject
	{
		/// <summary>
		/// Subscription ID (post ID)
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public int? id { get; set; }

		/// <summary>
		/// Order number
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public int? order_number { get; set; }

		/// <summary>
		/// UTC DateTime when the order was created
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public DateTime? created_at { get; set; }

		/// <summary>
		/// UTC DateTime when the order was last updated
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public DateTime? updated_at { get; set; }

		/// <summary>
		/// UTC DateTime when the order was last completed
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public DateTime? completed_at { get; set; }

		/// <summary>
		/// UTC DateTime for the subscription start date.
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public DateTime? start_date { get; set; }

		/// <summary>
		/// UTC DateTime for the subscriptions next payment date.
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public DateTime? next_payment_date { get; set; }

		/// <summary>
		/// UTC DateTime for the subscriptions trial end date.
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public DateTime? trial_end_date { get; set; }

		/// <summary>
		/// UTC DateTime for the subscription end date.
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public DateTime? end_date { get; set; }

		/// <summary>
		/// Subscription status. By default the statuses available are: pending, on-hold, active, pending-cancel, cancelled and expired.
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string status { get; set; }

		/// <summary>
		/// Billing period for the subscription. By default, valid billing periods are: day, week, month, year.
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string billing_period { get; set; }

		/// <summary>
		/// The number of billing periods between each payment cycle.
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public int billing_interval { get; set; }

		/// <summary>
		/// Currency in ISO format, e.g USD
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string currency { get; set; }

		/// <summary>
		/// Order total
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public float total { get; set; }

		/// <summary>
		/// Order subtotal
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public float subtotal { get; set; }

		/// <summary>
		/// Total of order items
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public int total_line_items_quantity { get; set; }

		/// <summary>
		/// Order subtotal
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public float total_tax { get; set; }

		/// <summary>
		/// Order shipping total 
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public float total_shipping { get; set; }

		/// <summary>
		/// Order cart tax
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public float cart_tax { get; set; }

		/// <summary>
		/// Order shipping tax
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public float shipping_tax { get; set; }

		/// <summary>
		/// Order total discount
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public float total_discount { get; set; }

		/// <summary>
		/// Text list of the shipping methods used in the order
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string shipping_methods { get; set; }

		/// <summary>
		/// List of payment details. 
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public SubscriptionPaymentDetails[] payment_details { get; set; }

		/// <summary>
		/// List of customer billing address.
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public BillingAddress[] billing_address { get; set; }

		/// <summary>
		/// List of customer shipping address.
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public ShippingAddress[] shipping_address { get; set; }

		/// <summary>
		/// Customer subscription notes
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string note { get; set; }

		/// <summary>
		/// Customer IP address
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string customer_ip { get; set; }

		/// <summary>
		/// Customer User-Agent
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string customer_user_agent { get; set; }

		/// <summary>
		/// Customer ID (user ID)
		/// required
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public int customer_id { get; set; }

		/// <summary>
		/// URL to view the subscription in frontend
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string view_order_url { get; set; }

		/// <summary>
		/// List of order line items.
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public SubscriptionLineItem[] line_items { get; set; }

		/// <summary>
		/// List of shipping line items.
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public SubscriptionShippingLine[] shipping_lines { get; set; }

		/// <summary>
		/// List of tax line items. 
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public SubscriptionTaxLine[] tax_lines { get; set; }

		/// <summary>
		/// List of fee line items.
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public SubscriptionFeeLine[] fee_lines { get; set; }

		/// <summary>
		/// List of cupon line items.
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public SubscriptionCouponLine[] coupon_lines { get; set; }

		/// <summary>
		/// Customer data.
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public SubscriptionCustomer customer { get; set; }
	}

	[DataContract]
	public class SubscriptionCustomer
	{
		/// <summary>
		/// Unique identifier for the resource. 
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public int? id { get; set; }

		/// <summary>
		/// The date the customer was created, in the site’s timezone. 
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public DateTime created_at { get; set; }

		/// <summary>
		/// The email address for the customer. 
		/// mandatory
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string email { get; set; }

		/// <summary>
		/// Customer first name.
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string first_name { get; set; }

		/// <summary>
		/// Customer last name.
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string last_name { get; set; }

		/// <summary>
		/// Customer login name. Can be generated automatically from the customer’s email addrees if the option woocommerce_registration_generate_username is equal to yes cannot be changed 
		/// cannot be changed</i> <i class="label label-info">maybe mandatory
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string username { get; set; }

		[DataMember(EmitDefaultValue = false)]
		public string role { get; set; }

		[DataMember(EmitDefaultValue = false)]
		public int? last_order_id { get; set; }

		[DataMember(EmitDefaultValue = false)]
		public DateTime? last_order_date { get; set; }

		/// <summary>
		/// Quantity of orders made by the customer. 
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public int? orders_count { get; set; }

		/// <summary>
		/// Total amount spent. 
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public decimal? total_spent { get; set; }

		/// <summary>
		/// Avatar URL.
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string avatar_url { get; set; }

		/// <summary>
		/// List of billing address data. See Billing Address properties.
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public BillingAddress billing { get; set; }

		/// <summary>
		/// List of shipping address data. See Shipping Address properties.
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public ShippingAddress shipping { get; set; }


	}

	[DataContract]
	public class SubscriptionPaymentDetails
	{
		/// <summary>
		/// Payment method ID
		/// required
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string method_id { get; set; }

		/// <summary>
		/// Payment method title
		/// required
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string method_title { get; set; }

		/// <summary>
		/// Transaction ID, an optional field to set the transacion ID when 
		/// complete one payment (to set this you need set the paid as true 
		/// too)
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string transaction_id { get; set; }
	}

	[DataContract]
	public class SubscriptionLineItem
	{
		/// <summary>
		/// Line item ID 
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public int? id { get; set; }

		/// <summary>
		/// Line item subtotal
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public float subtotal { get; set; }

		/// <summary>
		/// Line item tax subtotal
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public float subtotal_tax { get; set; }

		/// <summary>
		/// Line item total
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public float total { get; set; }

		/// <summary>
		/// Line item tax total
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public float total_tax { get; set; }

		/// <summary>
		/// Product price
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public float price { get; set; }

		/// <summary>
		/// Quantity
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public int? quantity { get; set; }

		/// <summary>
		/// Product tax class
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string tax_class { get; set; }

		/// <summary>
		/// Product name
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string name { get; set; }

		/// <summary>
		/// Product ID required. This value does not need to be a subscription 
		/// product.
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public int? product_id { get; set; }

		/// <summary>
		/// Product SKU
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string sku { get; set; }

		/// <summary>
		/// List of product meta items.
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public SubscriptionProductMeta[] meta { get; set; }

		/// <summary>
		/// List of product variation attributes. 
		/// e.g: "variation": {"pa_color": "Black", "pa_size": "XGG"} 
		/// (Use pa_ prefix when is a product attribute) 
		/// write-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string[] variations { get; set; }
	}

	[DataContract]
	public class SubscriptionProductMeta
	{
		/// <summary>
		/// Meta item key
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string key { get; set; }

		/// <summary>
		/// Meta item label
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string label { get; set; }

		/// <summary>
		/// Meta item value
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string value { get; set; }
	}

	[DataContract]
	public class SubscriptionShippingLine
	{
		/// <summary>
		/// Shipping line ID 
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public int? id { get; set; }

		/// <summary>
		/// Shipping method ID 
		/// required
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string method_id { get; set; }

		/// <summary>
		/// Shipping method title
		/// required
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string method_title { get; set; }

		/// <summary>
		/// Total amount
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public float title { get; set; }
	}

	[DataContract]
	public class SubscriptionTaxLine
	{
		/// <summary>
		/// Tax rate line ID 
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public int? id { get; set; }

		/// <summary>
		/// Tax rate ID 
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public int? rate_id { get; set; }

		/// <summary>
		/// Tax rate code 
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string code { get; set; }

		/// <summary>
		/// Tax rate title/name 
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string title { get; set; }

		/// <summary>
		/// Tax rate total 
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public float total { get; set; }

		/// <summary>
		/// Shows if is or not a compound rate. Compound tax rates are applied 
		/// on top of other tax rates. 
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public bool compound { get; set; }
	}

	[DataContract]
	public class SubscriptionFeeLine
	{
		/// <summary>
		/// Fee line ID 
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public int? id { get; set; }

		/// <summary>
		/// Shipping method title 
		/// required
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string title { get; set; }

		/// <summary>
		/// Shows/define if the fee is taxable 
		/// write-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public bool taxable { get; set; }

		/// <summary>
		/// Tax class, requeried in write-mode if the fee is taxable
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string tax_class { get; set; }

		/// <summary>
		/// Total amount
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public float total { get; set; }

		/// <summary>
		/// Tax total
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public float total_tax { get; set; }
	}

	[DataContract]
	public class SubscriptionCouponLine
	{
		/// <summary>
		/// Coupon line ID 
		/// read-only
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public int? id { get; set; }

		/// <summary>
		/// Coupon code 
		/// required
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public string code { get; set; }

		/// <summary>
		/// Total amount 
		/// required
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public float amount { get; set; }
	}
}