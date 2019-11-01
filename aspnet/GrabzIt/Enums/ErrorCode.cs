﻿using System;

namespace GrabzIt.Enums
{
    public enum ErrorCode
    {
        Success = 0,
        ParameterNoURL = 100,
        ParameterInvalidURL = 101,
        ParameterNonExistantURL = 102,
        ParameterMissingApplicationKey = 103,
        ParameterUnrecognisedApplicationKey = 104,
        ParameterMissingSignature = 105,
        ParameterInvalidSignature = 106,
        ParameterInvalidFormat = 107,
        ParameterInvalidCountryCode = 108,
        ParameterDuplicateIdentifier = 109,
        ParameterMatchingRecordNotFound = 110,
        ParameterInvalidCallBackURL = 111,
        ParameterNonExistantCallBackURL = 112,
        ParameterImageWidthTooLarge = 113,
        ParameterImageHeightTooLarge = 114,
        ParameterBrowserWidthTooLarge = 115,
        ParameterBrowserHeightTooLarge = 116,
        ParameterDelayTooLarge = 117,
        ParameterInvalidBackground = 118,
        ParameterInvalidIncludeLinks = 119,
        ParameterInvalidIncludeOutline = 120,
        ParameterInvalidPageSize = 121,
        ParameterInvalidPageOrientation = 122,
        ParameterVerticalMarginTooLarge = 123,
        ParameterHorizontalMarginTooLarge = 124,
        ParameterInvalidCoverUrl = 125,
        ParameterNonExistantCoverUrl = 126,
        ParameterMissingCookieName = 127,
        ParameterMissingCookieDomain = 128,
        ParameterInvalidCookieName = 129,
        ParameterInvalidCookieDomain = 130,
        ParameterInvalidCookieDelete = 131,
        ParameterInvalidCookieHTTP = 132,
        ParameterInvalidCookieExpiry = 133,
        ParameterInvalidCacheValue = 134,
        ParameterInvalidDownloadValue = 135,
        ParameterInvalidSupressValue = 136,
        ParameterMissingWaterMarkIdentifier = 137,
        ParameterInvalidWaterMarkIdentifier = 138,
        ParameterInvalidWaterMarkXPos = 139,
        ParameterInvalidWaterMarkYPos = 140,
        ParameterMissingWaterMarkFormat = 141,
        ParameterWaterMarkTooLarge = 142,
        ParameterMissingParameters = 143,
		ParameterQualityTooLarge = 144,
		ParameterQualityTooSmall = 145,
        ParameterRepeatTooSmall = 149,
        ParameterInvalidReverse = 150,
        ParameterFPSTooLarge = 151,
        ParameterFPSTooSmall = 152,
        ParameterSpeedTooFast = 153,
        ParameterSpeedTooSlow = 154,
        ParameterInvalidAnimationCombination = 155,
        ParameterStartTooSmall = 156,
        ParameterDurationTooSmall = 157,
        ParameterNoHTML = 163,
        ParameterInvalidTargetValue = 165,
        ParameterInvalidHideValue = 166,
        ParameterInvalidIncludeImages = 167,
        ParameterInvalidExportURL = 168,
        ParameterInvalidWaitForValue = 169,
        ParameterInvalidTransparentValue = 170,
        ParameterInvalidEncryptionKey = 171,
        ParameterInvalidNoAds = 172,
        ParameterInvalidProxy = 173,
        ParameterInvalidNoNotify = 174,
        ParameterInvalidHD = 176,
        ParameterInvalidMediaType = 177,
        ParameterInvalidPassword = 178,
        ParameterInvalidMerge = 179,
        NetworkServerOffline = 200,
        NetworkGeneralError = 201,
        NetworkDDOSAttack = 202,
        RenderingError = 300,
        RenderingMissingScreenshot = 301,
        GenericError = 400,
        UpgradeRequired = 500,
        FileSaveError = 600,
        FileNonExistantPath = 601
    }
}
