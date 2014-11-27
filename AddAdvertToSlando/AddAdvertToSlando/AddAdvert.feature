﻿Feature: AddAdvert
	Adding advert to bulletin board
	As a bulletin board user
	I should be able to add and delete an ad


Scenario: Add and delete advert to Slando
	Given that I open page  "http://olx.ua/"
	Then I see "btnMyAccount"
	When I click "btnMyAccount"
	Then I see "inputEmail"
	When I write "okorol.autotest.user@gmail.com" to "inputEmail"
	And I write "okorol.autotest.user" to "inputPassword"
	And I click "btnLogin"
	Then I see "btnLoggedUserName"
	When I click "btnPostFreeAds"
	Then I see "txtTitleToPlaceAnAd"
	When I write "Automation test for all" to "fldTitle"
	And I click "fldGroups"
	Then I see "btnBusinessAndServices"
	When I click "btnBusinessAndServices"
	And I see "listSubGroups"
	And I scroll "scrollbar" to "scrollbardown"
	And I click "btnSubGroups"
	Then I see "slctUserType"
	When I click "slctUserType"
	And I click "slctPrivatePerson"
	And I write "In software testing, test automation is the use of special software (separate from the software being tested) to control the execution of tests and the comparison of actual outcomes with predicted outcomes." to "fldDescription"
	And I click "btnPublish"
	Then I see "txtConfirmTitle"
	When I move to "btnLoggedUserName"
	And I click "btnAdverts"
	And I see "btnWaiting"
	And I click "btnWaiting"
	Then I see "txtWaitingAdvert"
	When I click "chckAdvert"
	And I see "btnDeleteAdverts"
	And I click "btnDeleteAdverts"
	Then I see "txtNotHaveAdverts"
	When I move to "btnLoggedUserName"
	And I click "btnQuit"
	Then I see "btnMyAccount"