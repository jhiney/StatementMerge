## Using the Merge


![alt text](https://github.com/jhiney/StatementMerge/blob/master/form.png "Picture of the form")

Because Microsft Word does not natively support adding differing attachments for mail merges, we must string together our own solution. When you run "StatementMerge" the above form will appear and will use the information you provide to send out the quarterly statements.

You must select a Quarter, Fiscal Year, "As Of" Date, File and Folder.
* Quarter and Fiscal Year are used to create the subject of your email.
* "As Of" Date is used in the body of your email.
* Folder is the directory where the statements you wish to send live.
* File is the .csv list of the statement recipients.

On the right side of the form you will see text confirming your selections. You will also have a chance to confirm them before sending as the merge creates drafts, it does not send out the actual emails.

## TODO:
* Add a email preview to the form
* Add a pop up that shows recipients and what attachments they are receiving
* Add something that pops up that lets you know if there are statements in the Folder that aren't assigned to a recipient.
* Fuzzy matching
