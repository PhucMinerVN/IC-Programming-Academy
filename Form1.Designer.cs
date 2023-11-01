using System.Web.Services;
using PayPal.SDK.Core;
using PayPal.SDK.UI;

namespace App;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        var client = new PayPalClient();

        // Create a payment request.
        var paymentRequest = new PaymentRequest();
        paymentRequest.Amount = 10.00;
        paymentRequest.CurrencyCode = "USD";
        paymentRequest.Intent = PaymentIntent.Sale;

        // Create a payment button.
        var paymentButton = new PaymentButton(client, paymentRequest);

        // Add the payment button to the form.
        this.Controls.Add(paymentButton);
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";
    }

    #endregion
}
