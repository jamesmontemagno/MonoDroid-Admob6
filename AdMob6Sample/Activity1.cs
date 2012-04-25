/*
 * Copyright (C) 2012 James Montemagno (motz2k1@oh.rr.com) http://www.montemagno.com
 * 
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 */

using Android.App;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AdMob6Sample
{
    [Activity(Label = "AdMob6Sample", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        private View m_AdView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            m_AdView = FindViewById(Resource.Id.adView);

            var button = FindViewById<Button>(Resource.Id.ButtonRefreshAd);

            button.Click += ((sender, args) => AdMobHelper.LoadAd(m_AdView));
        }

        protected override void OnDestroy()
        {
            if(m_AdView != null)
               AdMobHelper.Destroy(m_AdView);
            base.OnDestroy();
        }
    }
}

