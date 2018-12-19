# renewable-energy-credits
> This is a template of a project using [Tracker](https://www.mantleblockchain.com/tracker) to build a simple platform where users can issue, manage and transfer credits of green energy.

## Before you start
> You might find it easier to implement this project after reading our [documentation](https://docs.mantleblockchain.com).

## Functionalities
- [x] Create green energy assets
- [x] Issue green credits for a specific green energy
- [x] List your green credits per green energy
- [ ] Handle multiple users
- [ ] List the buy and sell order books
- [ ] Buy green credits in the marketplace
- [ ] Sell green credits in the marketplace

## Prerequisites
### Backend
> You will need the update the values following values `mantle-config.yaml` to run the backend project:

``` yaml
# This is the product id of the Tracker you are going to use
productId: your-product-id
# This is the API key you will use to make calls to the Mantle API
apiKey: your-api-key
# This is the URL of the Mantle API you are going to call
apiUrl: your-api-url
```

### Frontend
> You will need to update the `userEmail` variable in this file: `src/components/IssueBtn.vue`
> This is user email that will be issued some green credits.
> The user must exist in the Mantle platform.
