# CyberSource.Model.RiskV1AddressVerificationsPost201Response
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**PtsV2IncrementalAuthorizationPatch201ResponseLinks**](PtsV2IncrementalAuthorizationPatch201ResponseLinks.md) |  | [optional] 
**Id** | **string** | An unique identification number generated by Cybersource to identify the submitted request. Returned by all services. It is also appended to the endpoint of the resource. On incremental authorizations, this value with be the same as the identification number returned in the original authorization response.  | [optional] 
**SubmitTimeUtc** | **string** | Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; **Example** &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  Returned by Cybersource for all services.  | [optional] 
**SubmitTimeLocal** | **string** | Time that the transaction was submitted in local time. Generated by Cybersource. | [optional] 
**Status** | **string** | The status for the call can be: - COMPLETED - INVALID_REQUEST - DECLINED  | [optional] 
**Message** | **string** | The message describing the reason of the status. Value can be   - Apartment number missing or not found.   - Insufficient address information.   - House/Box number not found on street.   - Multiple address matches were found.   - P.O. Box identifier not found or out of range.   - Route service identifier not found or out of range.   - Street name not found in Postal code.   - Postal code not found in database.   - Unable to verify or correct address.   - Multiple addres matches were found (international)   - Address match not found (no reason given)   - Unsupported character set  | [optional] 
**ClientReferenceInformation** | [**RiskV1DecisionsPost201ResponseClientReferenceInformation**](RiskV1DecisionsPost201ResponseClientReferenceInformation.md) |  | [optional] 
**AddressVerificationInformation** | [**RiskV1AddressVerificationsPost201ResponseAddressVerificationInformation**](RiskV1AddressVerificationsPost201ResponseAddressVerificationInformation.md) |  | [optional] 
**ErrorInformation** | [**RiskV1AddressVerificationsPost201ResponseErrorInformation**](RiskV1AddressVerificationsPost201ResponseErrorInformation.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
